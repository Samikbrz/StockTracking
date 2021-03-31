using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ProductUnitsController : ControllerBase
	{
		IProductUnitService _productUnitService;
		public ProductUnitsController(IProductUnitService productUnitService)
		{
			_productUnitService = productUnitService;
		}

		[HttpGet("getall")]
		public IActionResult GetList()
		{
			var result = _productUnitService.GetAll();
			if (result.Success)
			{
				return Ok(result.Data);
			}

			return BadRequest(result.Message);
		}

		[HttpPost("add")]
		public IActionResult Add(ProductUnit productUnit)
        {			
			var result = _productUnitService.Add(productUnit);
			if (result.Success)
			{
				return Ok(result.Message);
			}

            return BadRequest(result.Message);
		}		

		[HttpPost("update")]
		public IActionResult Update(ProductUnit productUnit)
		{
			var result = _productUnitService.Update(productUnit);
			if (result.Success)
			{
				return Ok(result.Message);
			}

			return BadRequest(result.Message);
		}

		[HttpPost("delete")]
		public IActionResult Delete(ProductUnit productUnit)
		{
			var result = _productUnitService.Delete(productUnit);
			if (result.Success)
			{
				return Ok(result.Message);
			}

			return BadRequest(result.Message);
		}
	}
}
