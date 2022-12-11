using Microsoft.AspNetCore.Mvc;
using NintendoShop.Catalog.BLL.DTOs.GameProduct;
using NintendoShop.Catalog.BLL.Interfaces;

namespace NintendoShop.Catalog.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class GameProductController : ControllerBase
    {
        private readonly IGameProductService _gameProductService;
        public GameProductController(IGameProductService gameProductService)
        {
            _gameProductService = gameProductService;
        }

        [HttpGet("all")]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                var gameProducts = await _gameProductService.GetAllAsync();

                return Ok(gameProducts);
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById([FromRoute] string id)
        {
            try
            {
                var gameProduct = await _gameProductService.GetByIdAsync(id);

                return Ok(gameProduct);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateGameProductDto gameProduct)
        {
            try
            {
                await _gameProductService.CreateAsync(gameProduct);

                return StatusCode(201);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        public async Task<IActionResult> Update([FromBody] UpdateGameProductDto gameProduct)
        {
            try
            {
                await _gameProductService.UpdateAsync(gameProduct);

                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete([FromRoute] string id)
        {
            try
            {
                await _gameProductService.DeleteAsync(id);

                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}