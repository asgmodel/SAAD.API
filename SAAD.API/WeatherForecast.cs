using System.Net.Http.Headers;
using System.Security.Claims;
using Microsoft.AspNetCore.Http;
namespace Saad.API
{

    

    public class UserClaimsHelper
    {
        private readonly IHttpContextAccessor _httpContextAccessor;

        public UserClaimsHelper(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        private ClaimsPrincipal User => _httpContextAccessor.HttpContext?.User;

        public string GetUserName()
        {
            return User?.FindFirst(ClaimTypes.Name)?.Value;
        }

        public string GetEmail()
        {
            return User?.FindFirst(ClaimTypes.Email)?.Value;
        }

        public string GetRole()
        {
            return User?.FindFirst(ClaimTypes.Role)?.Value;
        }

        public string GetId()
        {
            return User?.FindFirst(ClaimTypes.NameIdentifier)?.Value;
        }

        public bool HasRole(string role)
        {
            var userRole = GetRole();
            return string.Equals(userRole, role, StringComparison.OrdinalIgnoreCase);
        }
    }


    public interface IClientFactory
    {
        Task<HttpClient> GetClientAsync(bool isUsedToken = true);
        public Task<string> gettoken();
    }

    public class HttpClientFactory : IClientFactory
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly IConfiguration _configuration;
        private readonly ILogger<HttpClientFactory> _logger;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public HttpClientFactory(
            IHttpClientFactory httpClientFactory,
            IConfiguration configuration,
            ILogger<HttpClientFactory> logger,
            IHttpContextAccessor httpContextAccessor)
        {
            _httpClientFactory = httpClientFactory;
            _configuration = configuration;
            _logger = logger;
            _httpContextAccessor = httpContextAccessor;

        }

        public Task<string> gettoken()
        {
            var token = _httpContextAccessor.HttpContext?.Request.Headers["Authorization"].ToString();
            return Task.FromResult(token);
        }
        public Task<HttpClient> GetClientAsync(bool isUsedToken=true)
        {
            try
            {
                var client = _httpClientFactory.CreateClient("SallaApi");

                // Configure defaults
                client.BaseAddress = new Uri(_configuration["ApiSalla:BaseUrl"]);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(
                    new MediaTypeWithQualityHeaderValue("application/json"));
                if (!isUsedToken) 
                    return Task.FromResult(client);
                var token = _httpContextAccessor.HttpContext?.Request.Headers["Authorization"].ToString();
                if (!string.IsNullOrEmpty(token))
                {
                    client.DefaultRequestHeaders.Authorization =
                        new AuthenticationHeaderValue("Bearer", token.Replace("Bearer ", ""));
                }
                return Task.FromResult(client);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Failed to create HttpClient");
                throw;
            }
        }
    }
    public class LahjaOAuthOptions
    {
        public string ClientId { get; set; } = string.Empty;
        public string? ClientSecret { get; set; }
        public string AppName { get; set; } = "Swagger";
        public bool UsePkce { get; set; } = true;
        public string ScopeSeparator { get; set; } = " ";


        public string ApiScope { get; set; } = " ";
        public string IdentityServerBaseUrl { get; set; } = " ";
    }
    public class WeatherForecast
    {
        public DateOnly Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public string? Summary { get; set; }
    }
}
