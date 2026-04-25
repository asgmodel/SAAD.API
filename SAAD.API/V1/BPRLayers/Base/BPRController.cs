
using AutoGenerator;
using AutoGenerator.Controllers.Base;
using AutoGenerator.Repositories.Base;
using Microsoft.AspNetCore.Mvc;
using AutoMapper;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;

namespace V1.BPR.Layers.Base
{
    public abstract class BaseBPRControllerLayer<TRequest, TResponse, VMCreate, VMOutput, VMUpdate, VMInfo, VMDelete> 
        : BaseBPRController<TRequest, TResponse, VMCreate, VMOutput, VMUpdate, VMInfo, VMDelete>
        where TRequest : class
        where TResponse : class
        where VMCreate : class
        where VMOutput : class
        where VMUpdate : class
        where VMInfo : class
        where VMDelete : class
    {
        protected IBPRLayer<TRequest, TResponse> _bpr;
        protected BaseBPRControllerLayer(IMapper mapper, ILoggerFactory logger, IBPRLayer<TRequest, TResponse> bPR) 
            : base(mapper, logger, bPR)
        {
            _bpr = bPR;
        }

       [HttpGet( "GetAll")]
       public override  Task<ActionResult<IEnumerable<VMOutput>>> GetAllAsync()
        {
            return base.GetAllAsync();
        }

       [HttpDelete("Delete/{id}")]
       public override Task<ActionResult<bool>> DeleteAsync(string id){
          return base.DeleteAsync(id);
        }
       [HttpPut("Update/{id}")]
       public override  Task<ActionResult<VMOutput>> UpdateAsync([FromRoute] string id, [FromBody] VMUpdate model)
        {
            return base.UpdateAsync(id, model);
        } 
       

       [HttpPost("Create")]
       public override Task<ActionResult<VMOutput>> CreateAsync([FromBody] VMCreate model)
        {
            return base.CreateAsync(model);
        }

        [HttpGet("Get/{id}")]
        public override Task<ActionResult<VMInfo>> GetByIdAsync(string id)
        {
            return base.GetByIdAsync(id);
        }
        

    }


     /////////// ControllerLayerWithFilter LG/////////////
    public abstract class BaseBPRControllerLayer<TRequest, TResponse, VMCreate, VMOutput, VMUpdate, VMInfo, VMDelete, VMFilter> 
        : BaseBPRController<TRequest, TResponse, VMCreate, VMOutput, VMUpdate, VMInfo, VMDelete, VMFilter>
        where TRequest : class
        where TResponse : class
        where VMCreate : class
        where VMOutput : class
        where VMUpdate : class
        where VMInfo : class
        where VMDelete : class
        where VMFilter : class
    {
        protected IBPRLayer<TRequest, TResponse> _bpr;
        protected BaseBPRControllerLayer(IMapper mapper, ILoggerFactory logger, IBPRLayer<TRequest, TResponse> bPR) 
            : base(mapper, logger, bPR)
        {
            _bpr = bPR;
        }

              [HttpGet( "GetAll")]
       public override  Task<ActionResult<IEnumerable<VMOutput>>> GetAllAsync()
        {
            return base.GetAllAsync();
        }


        [HttpGet("query")]
        public virtual async Task<ActionResult<IEnumerable<VMOutput>>> GetFromQuery()
        {
            var query = _bPR.GetQueryable();

            var data = await query.ToListAsync();

            var result = _mapper.Map<IEnumerable<VMOutput>>(data);

            return Ok(result);
        }

        [HttpGet("GetPagedQueryAsync")]
        [ProducesResponseType(200)]
        [ProducesResponseType(401)]
        public virtual async Task<ActionResult<PagedResponse<VMOutput>>> GetGetPagedQueryAsyncPagedAsync(
   [FromQuery] int pageNumber = 1,
   [FromQuery] int pageSize = 10,
   [FromQuery] string? search = null)
        {
            var query = _bPR.GetQueryable();

            

            var totalRecords = await query.CountAsync();

            var data = await query
                .Skip((pageNumber - 1) * pageSize)
                .Take(pageSize)
                .ToListAsync();

            var mappedData = _mapper.Map<IEnumerable<VMOutput>>(data);

            var response = new PagedResponse<VMOutput>(
                mappedData,
                pageNumber,
                pageSize,
                totalRecords
            );

            return Ok(response);
        }

        [HttpGet("paged")]
        [ProducesResponseType(200)]
        [ProducesResponseType(401)]
        public virtual async Task<ActionResult<PagedResponse<VMOutput>>> GetAllAsync(
           [FromQuery] string[]? includes,
           [FromQuery] int pageNumber = 1,
           [FromQuery] int pageSize = 10)
        {
            var result = await _bPR.GetAllAsync(includes, pageNumber, pageSize);

            if (result == null)
            {
                _logger.LogWarning("Failed to retrieve paged data");
                return BadRequest("Error retrieving data");
            }

            //  ÕÊÌ· «·»Ì«‰«  œ«Œ· «·‹ Pagination
            var mappedData = _mapper.Map<IEnumerable<VMOutput>>(result.Data);

            var response = new PagedResponse<VMOutput>(mappedData,
                  result.PageNumber,
                  result.PageSize,
                  result.TotalRecords

                );
            

            return Ok(response);
        }



        [HttpDelete("Delete/{id}")]
       public override Task<ActionResult<bool>> DeleteAsync(string id){
          return base.DeleteAsync(id);
        }
       [HttpPut("Update/{id}")]
       public override  Task<ActionResult<VMOutput>> UpdateAsync([FromRoute] string id, [FromBody] VMUpdate model)
        {
            return base.UpdateAsync(id, model);
        }
        [HttpPut("{id}")]
        [ProducesResponseType(200)]
        [ProducesResponseType(401)]
        [ProducesResponseType(typeof(ProblemDetails), 404)]
        [ProducesResponseType(400)]

        public virtual async Task<ActionResult<VMOutput>> UpdateAsyncbyid([FromRoute] string id, [FromBody] VMUpdate model)
        {
            if (!base.ModelState.IsValid)
            {
                _logger.LogWarning("Model validation failed on update.");
                return BadRequest("Invalid model");
            }

            TResponse val = await _bPR.GetByIdAsync(id);
            if (val == null)
            {
                _logger.LogWarning("Item with ID {Id} not found for update.", id);
                return NotFound(new ProblemDetails
                {
                    Title = "Update Failed",
                    Detail = "Item not found"
                });
            }

            //model.PatchProperties(val);
            val.PatchProperties(model);
            var req = _mapper.Map<TRequest>(model);
            DataResult <TResponse> dataResult = await _bPR.UpdateDataResultAsync(req);
            if (!dataResult.Success || dataResult.Data == null)
            {
                _logger.LogWarning("Failed to update item: {Message}", dataResult.Message);
                return NotFound(new ProblemDetails
                {
                    Title = "Update Failed",
                    Detail = (dataResult.Message ?? "Item not found")
                });
            }

            TResponse value = _mapper.Map<TResponse>(dataResult.Data);
            return Ok(value);
        }
        [HttpPost("Create")]
       public override Task<ActionResult<VMOutput>> CreateAsync([FromBody] VMCreate model)
        {
            return base.CreateAsync(model);
        }

       
        [HttpGet("Get/{id}")]
        public override Task<ActionResult<VMInfo>> GetByIdAsync(string id)
        {
            return base.GetByIdAsync(id);
        }
    }
}