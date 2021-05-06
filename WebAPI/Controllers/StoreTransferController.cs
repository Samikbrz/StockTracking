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
    public class StoreTransferController : ControllerBase
    {
        IStoreTransferService _storeTransferService;
        public StoreTransferController(IStoreTransferService storeTransferService)
        {
            _storeTransferService = storeTransferService;
        }

        [HttpGet("getall")]
        public IActionResult GetList()
        {
            var result = _storeTransferService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpPost("add")]
        public IActionResult Add(StoreTransfer storeTransfer)
        {
            var result = _storeTransferService.Add(storeTransfer);
            if (result.Success)
            {
                return Ok(result.Message);
            }

            return BadRequest(result.Message);
        }

        [HttpPost("update")]
        public IActionResult Update(StoreTransfer storeTransfer)
        {
            var result = _storeTransferService.Update(storeTransfer);
            if (result.Success)
            {
                return Ok(result.Message);
            }

            return BadRequest(result.Message);
        }

        [HttpPost("delete")]
        public IActionResult Delete(StoreTransfer storeTransfer)
        {
            var result = _storeTransferService.Delete(storeTransfer);
            if (result.Success)
            {
                return Ok(result.Message);
            }

            return BadRequest(result.Message);
        }
	}
}
