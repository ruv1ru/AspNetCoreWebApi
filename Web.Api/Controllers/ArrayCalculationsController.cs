
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Web.Core.Interfaces;
using Web.Core.Services;

namespace Web.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArrayCalcController : ControllerBase
    {
        private readonly IArrayCalculationService _arrayCalcService;

        public ArrayCalcController(IArrayCalculationService arrayCalcService)
        {
            _arrayCalcService = arrayCalcService;
        }
        
        [HttpGet]
        [Route("reverse")]        
        public async Task<ActionResult<IEnumerable<int>>> Get([FromQuery] int[] productIds)
        {
            return await _arrayCalcService.ReverseArray(productIds);
        }

        [HttpGet]
        [Route("deletepart")]        
        public async Task<ActionResult<IEnumerable<int>>> Get(int position, [FromQuery] int[] productIds)
        {
            return await _arrayCalcService.DeleteItem(position, productIds);
        }


    }
}

