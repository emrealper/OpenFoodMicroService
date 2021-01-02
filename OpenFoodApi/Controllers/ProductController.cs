using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OpenFood.Application.Services.Queries.GetProductListByIngredient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OpenFoodApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : BaseController
    {


        [HttpGet("{Ingredient}/{Limit}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<IList<ProductListVm>>> GetAll(string Ingredient,int Limit)
        {
            var vm = await Mediator.Send(new GetProductListByIngredientQuery { Ingredient = Ingredient,Limit=Limit });

            return Ok(vm.Products.Take(Limit));
        }





    

    }
}
