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
    public class StockKindController : ControllerBase
    {
        private IStockKindService _stockKindService;
        public StockKindController(IStockKindService stockKindService)
        {
            _stockKindService = stockKindService;
        }

        [HttpGet("getall")]
        public IActionResult GetList()
        {
            var result = _stockKindService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpPost("add")]
        public IActionResult Add(StockKind stockKind)
        {
            var result = _stockKindService.Add(stockKind);
            if (result.Success)
            {
                return Ok(result.Message);
            }

            return BadRequest(result.Message);
        }

        [HttpPost("update")]
        public IActionResult Update(StockKind stockKind)
        {
            var result = _stockKindService.Update(stockKind);
            if (result.Success)
            {
                return Ok(result.Message);
            }

            return BadRequest(result.Message);
        }

        [HttpPost("delete")]
        public IActionResult Delete(StockKind stockKind)
        {
            var result = _stockKindService.Delete(stockKind);
            if (result.Success)
            {
                return Ok(result.Message);
            }

            return BadRequest(result.Message);
        }
	}
}
