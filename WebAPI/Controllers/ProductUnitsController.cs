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

        [HttpGet]
        public IActionResult Get()
        {           
            var result = _productUnitService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest();
        }
    }
}
