using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;
using Entities.Concrete;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductOutputController : ControllerBase
    {
        private IProductOutputService _productOutputService;

        public ProductOutputController(IProductOutputService productOutputService)
        {
            _productOutputService = productOutputService;
        }

        [HttpGet("getall")]
        public IActionResult GetList()
        {
            var result = _productOutputService.GetAll();
            if (result.Success)
            {
                return Ok(result.Data);
            }

            return BadRequest(result.Message);
        }

        [HttpPost("add")]
        public IActionResult Add(ProductOutput productOutput)
        {
            var result = _productOutputService.Add(productOutput);
            if (result.Success)
            {
                return Ok(result.Message);
            }

            return BadRequest(result.Message);
        }

        [HttpPost("update")]
        public IActionResult Update(ProductOutput productOutput)
        {
            var result = _productOutputService.Update(productOutput);
            if (result.Success)
            {
                return Ok(result.Message);
            }

            return BadRequest(result.Message);
        }

        [HttpPost("delete")]
        public IActionResult Delete(ProductOutput productOutput)
        {
            var result = _productOutputService.Delete(productOutput);
            if (result.Success)
            {
                return Ok(result.Message);
            }

            return BadRequest(result.Message);
        }
    }
}
