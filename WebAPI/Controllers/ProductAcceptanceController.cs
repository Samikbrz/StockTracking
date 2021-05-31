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
    public class ProductAcceptanceController : ControllerBase
    {
        private IProductAcceptanceService _productAcceptanceService;
        public ProductAcceptanceController(IProductAcceptanceService productAcceptanceService)
        {
            _productAcceptanceService = productAcceptanceService;
        }

        [HttpGet("getall")]
        public IActionResult GetList()
        {
            var result = _productAcceptanceService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result.Message);
        }

        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            var result = _productAcceptanceService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result.Message);
        }

        [HttpGet("getdetail")]
        public IActionResult GetDetail()
        {
            var result = _productAcceptanceService.GetDetail();
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result.Message);
        }

        [HttpPost("add")]
        public IActionResult Add(ProductAcceptance productAcceptance)
        {
            var result = _productAcceptanceService.Add(productAcceptance);
            if (result.Success)
            {
                return Ok(result.Message);
            }

            return BadRequest(result.Message);
        }

        [HttpPost("update")]
        public IActionResult Update(ProductAcceptance productAcceptance)
        {
            var result = _productAcceptanceService.Update(productAcceptance);
            if (result.Success)
            {
                return Ok(result.Message);
            }

            return BadRequest(result.Message);
        }

        [HttpPost("delete")]
        public IActionResult Delete(ProductAcceptance productAcceptance)
        {
            var result = _productAcceptanceService.Delete(productAcceptance);
            if (result.Success)
            {
                return Ok(result.Message);
            }

            return BadRequest(result.Message);
        }
    }
}
