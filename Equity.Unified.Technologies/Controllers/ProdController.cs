using Equity.Unified.Technologies.Api.DtoConvertions;
using Equity.Unified.Technologies.Api.Models.Domain.Product;
using Equity.Unified.Technologies.Api.Repos.Contracts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Equity.Unified.Technologies.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdController : ControllerBase
    {
        private readonly IProductRepo _productRepo;
        public ProdController(IProductRepo productRepo)
        {
            this._productRepo = productRepo;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProdDto>>> GetItems()
        {
            try
            {
                var products = await this._productRepo.GetProds();
                var Categories = await this._productRepo.GetCategories();
                if (products == null || Categories == null)
                {
                    return NotFound();
                }
                else
                {
                    var productDto = products.ConvertProductToDto(Categories);
                    return Ok(productDto);
                }
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                                                "Error retrieving data");
            }
        }
    }
}
