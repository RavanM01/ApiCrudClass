using Business.DTOs.Model;
using Business.Helpers.Exceptions.Model;
using Business.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ModelsController : ControllerBase
    {
        readonly IModelService modelService;

        public ModelsController(IModelService modelService)
        {
            this.modelService = modelService;
        }
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            try
            {
                return Ok(modelService.GetById(id));
            }
            catch (ModelNullException ex)
            {
                return NotFound(ex.Message);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }

        [HttpPost]
        public async Task<IActionResult> CreateAsync([FromForm] CreateModelDto dto)
        {
            try
            {
                return Ok(await modelService.CreateAsync(dto));
            }
            catch (ModelNameExsistException ex)
            {
                return StatusCode(StatusCodes.Status409Conflict, ex.Message);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPut]
        public async Task<IActionResult> Update([FromForm] UpdateModelDto dto)
        {
            try
            {
                await modelService.Update(dto);
                return Ok();
            }
 
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                await modelService.Delete(id);
                return NoContent();
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

    
    }
}