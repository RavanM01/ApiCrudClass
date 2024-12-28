using Business.DTOs.Color;
using Business.DTOs.Model;
using Business.Helpers.Exceptions.Model;
using Business.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ColorsController : ControllerBase
    {
        readonly IColorService modelService;

        public ColorsController(IColorService modelService)
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
        public async Task<IActionResult> CreateAsync([FromForm] CreateColorDto dto)
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
        public async Task<IActionResult> Update([FromForm] UpdateColorDto dto)
        {
            try
            {
                await modelService.Update(dto);
                return Ok();
            }

            catch (Exception ex)
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
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
