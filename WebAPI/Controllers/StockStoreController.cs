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
    public class StockStoreController : ControllerBase
    {
        private IStockStoreService _stockStoreService;
        public StockStoreController(IStockStoreService stockStoreService)
        {
            _stockStoreService = stockStoreService;
        }

        [HttpGet("getdetail")]
        public IActionResult GetList()
        {
            var result = _stockStoreService.GetDetail();
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            var result = _stockStoreService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpGet("getbyproductacceptanceid")]
        public IActionResult GetByProductAcceptanceId(int id)
        {
            var result = _stockStoreService.GetByProductAcceptanceId(id);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpPost("add")]
        public IActionResult Add(StockStore stockStore)
        {
            var result = _stockStoreService.Add(stockStore);
            if (result.Success)
            {
                return Ok(result.Message);
            }

            return BadRequest(result.Message);
        }

        [HttpPost("update")]
        public IActionResult Update(StockStore stockStore)
        {
            var result = _stockStoreService.Update(stockStore);
            if (result.Success)
            {
                return Ok(result.Message);
            }

            return BadRequest(result.Message);
        }

        [HttpPost("delete")]
        public IActionResult Delete(StockStore stockStore)
        {
            var result = _stockStoreService.Delete(stockStore);
            if (result.Success)
            {
                return Ok(result.Message);
            }

            return BadRequest(result.Message);
        }
	}
}
