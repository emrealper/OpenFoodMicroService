

using MediatR;
using Newtonsoft.Json;
using OpenFood.Application.Common.Exceptions;
using OpenFood.Application.Common.Interfaces;
using OpenFood.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace OpenFood.Application.Services.Queries.GetProductListByIngredient
{
    public class GetProductListByIngredientQueryHandler: IRequestHandler<GetProductListByIngredientQuery, ProductListVm>
    {

        private readonly IOpenFoodService _openFoodService;



        public GetProductListByIngredientQueryHandler(IOpenFoodService openFoodService)
        {
            _openFoodService = openFoodService;


        }

        public async Task<ProductListVm> Handle(GetProductListByIngredientQuery request, CancellationToken cancellationToken)
        {
            string productsJson = await _openFoodService.GetProductsByIngredientName(request.Ingredient,request.Limit);

            var vm = JsonConvert.DeserializeObject<ProductListVm>(productsJson);


            if (vm.Products.Count==0)
            {
                throw new NotFoundException(nameof(Ingredient), request.Ingredient);
            }

            return vm;
        }


    }
}
