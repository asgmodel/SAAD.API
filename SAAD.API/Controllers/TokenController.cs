using Microsoft.AspNetCore.Mvc;
using System.Collections.Concurrent;

namespace WebApplication2.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TokenController : ControllerBase
    {
        private static readonly ConcurrentDictionary<string, TokenItem> TokenIndex = new();

        [HttpPost("add")]
        public IActionResult Add([FromBody] AddTokenRequest request)
        {
            // Validate request
            if (request == null)
                return BadRequest(new ApiResponse("Request body is required"));

            if (string.IsNullOrWhiteSpace(request.Token))
                return BadRequest(new ApiResponse("Token is required"));

            var token = request.Token.Trim();

            // Check if token already exists (case-insensitive)
            bool tokenExists = TokenIndex.Values.Any(x =>
                string.Equals(x.Token, token, StringComparison.OrdinalIgnoreCase));

            if (tokenExists)
                return Conflict(new ApiResponse("This token already exists."));

            // Generate or use provided ID
            var id = string.IsNullOrWhiteSpace(request.Id)
                ? Guid.NewGuid().ToString()
                : request.Id.Trim();

            // Check if ID already exists
            if (TokenIndex.ContainsKey(id))
                return Conflict(new ApiResponse("This ID already exists."));

            // Create token object
            var item = new TokenItem
            {
                Id = id,
                Token = token,
                Name = string.IsNullOrWhiteSpace(request.Name)
                    ? null
                    : request.Name.Trim(),
                IsActive = true,
                UsageCount = 0,
                LastUsedAt = null,
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = null
            };

            // Save token
            TokenIndex.TryAdd(id, item);

            return Ok(new ApiResponse<TokenItem>(
                "Token added successfully.",
                item
            ));
        }

        [HttpGet("get/{id}")]
        public IActionResult Get(string id)
        {
            if (string.IsNullOrWhiteSpace(id))
                return BadRequest(new ApiResponse("ID is required"));

            if (!TokenIndex.TryGetValue(id, out var item))
                return NotFound(new ApiResponse("Token not found"));

            return Ok(new ApiResponse<TokenItem>(
                "Token fetched successfully",
                item
            ));
        }

        [HttpGet("all")]
        public IActionResult GetAll()
        {
            var items = TokenIndex.Values
                .OrderByDescending(x => x.CreatedAt)
                .ToList();

            return Ok(new ApiResponse<List<TokenItem>>(
                "Tokens fetched successfully",
                items
            ));
        }

        [HttpGet("visitor-token")]
        public IActionResult GetTokenForVisitor()
        {
            var item = TokenIndex.Values
                .Where(x => x.IsActive)
                .OrderBy(x => x.UsageCount)
                .ThenBy(x => x.LastUsedAt ?? DateTime.MinValue)
                .ThenBy(x => x.CreatedAt)
                .FirstOrDefault();

            if (item == null)
                return NotFound(new ApiResponse("No active tokens available"));

            item.UsageCount++;
            item.LastUsedAt = DateTime.UtcNow;
            item.UpdatedAt = DateTime.UtcNow;

            TokenIndex[item.Id] = item;

            return Ok(new ApiResponse<TokenVisitorResponse>(
                "Token selected successfully",
                new TokenVisitorResponse
                {
                    //Id = item.Id,
                    Token = item.Token
                    //Name = item.Name
                    //UsageCount = item.UsageCount,
                    //LastUsedAt = item.LastUsedAt
                }
            ));
        }

        [HttpPut("update/{id}")]
        public IActionResult Update(string id, [FromBody] UpdateTokenRequest request)
        {
            if (request == null)
                return BadRequest(new ApiResponse("Request body is required"));

            if (!TokenIndex.TryGetValue(id, out var item))
                return NotFound(new ApiResponse("Token not found"));

            if (!string.IsNullOrWhiteSpace(request.Token))
                item.Token = request.Token.Trim();

            if (request.Name != null)
                item.Name = request.Name;

            if (request.IsActive.HasValue)
                item.IsActive = request.IsActive.Value;

            item.UpdatedAt = DateTime.UtcNow;

            TokenIndex[id] = item;

            return Ok(new ApiResponse<TokenItem>(
                "Token updated successfully",
                item
            ));
        }

        [HttpDelete("delete/{id}")]
        public IActionResult Delete(string id)
        {
            if (!TokenIndex.TryRemove(id, out _))
                return NotFound(new ApiResponse("Token not found"));

            return Ok(new ApiResponse<string>(
                "Token deleted successfully",
                id
            ));
        }

        [HttpPut("reset-usage/{id}")]
        public IActionResult ResetUsage(string id)
        {
            if (!TokenIndex.TryGetValue(id, out var item))
                return NotFound(new ApiResponse("Token not found"));

            item.UsageCount = 0;
            item.LastUsedAt = null;
            item.UpdatedAt = DateTime.UtcNow;

            TokenIndex[id] = item;

            return Ok(new ApiResponse<TokenItem>(
                "Token usage reset successfully",
                item
            ));
        }

        public class AddTokenRequest
        {
            public string? Id { get; set; }
            public string Token { get; set; } = string.Empty;
            public string? Name { get; set; }
        }

        public class UpdateTokenRequest
        {
            public string? Token { get; set; }
            public string? Name { get; set; }
            public bool? IsActive { get; set; }
        }

        public class TokenItem
        {
            public string Id { get; set; } = string.Empty;
            public string Token { get; set; } = string.Empty;
            public string? Name { get; set; }
            public bool IsActive { get; set; }

            public int UsageCount { get; set; }
            public DateTime? LastUsedAt { get; set; }

            public DateTime CreatedAt { get; set; }
            public DateTime? UpdatedAt { get; set; }
        }

        public class TokenVisitorResponse
        {
            public string Id { get; set; } = string.Empty;
            public string Token { get; set; } = string.Empty;
            public string? Name { get; set; }
            public int UsageCount { get; set; }
            public DateTime? LastUsedAt { get; set; }
        }

        public class ApiResponse
        {
            public bool Success { get; set; }
            public string Message { get; set; }

            public ApiResponse(string message, bool success = false)
            {
                Success = success;
                Message = message;
            }
        }

        public class ApiResponse<T>
        {
            public bool Success { get; set; } = true;
            public string Message { get; set; }
            public T? Data { get; set; }

            public ApiResponse(string message, T? data)
            {
                Message = message;
                Data = data;
            }
        }
    }
}
