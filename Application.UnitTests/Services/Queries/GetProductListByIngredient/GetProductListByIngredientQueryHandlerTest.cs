
using OpenFood.Application.Common.Interfaces;
using OpenFood.Application.Services.Queries.GetProductListByIngredient;
using Shouldly;
using System.Threading;
using System.Threading.Tasks;
using Xunit;
using Moq;
using Newtonsoft.Json;
using RestSharp;
using System.Collections.Generic;
using Microsoft.AspNetCore.WebUtilities;
using System;

namespace Application.UnitTests.Services.Queries.GetProductListByIngredient
{
   public class GetProductListByIngredientQueryHandlerTest
    {





     

        [Fact]
        public async Task Handle_ReturnsCorrectVmAndListCount()
        {
         

            Mock<IOpenFoodService> mockObject = new Mock<IOpenFoodService>();


            const string baseAddress = "https://world.openfoodfacts.org/cgi/search.pl?";
            var _params = new Dictionary<string, string>() { { "action", "process" },
                {"tagtype_0", "ingredients" },
                {"tag_contains_0", "contains" },
                {"tag_0", "water" },
                 {"page_size", "20" },
                 {"json", "true" },


                };



            var openFoodFactsApiUrl = new Uri(QueryHelpers.AddQueryString(baseAddress, _params));


            var client = new RestClient(openFoodFactsApiUrl);
            client.Timeout = -1;
            var request = new RestRequest(Method.GET);
            IRestResponse response = client.Execute(request);

            mockObject.Setup(m => m.GetProductsByIngredientName("Water",20)).Returns(Task.FromResult(response.Content));



            var result = await mockObject.Object.GetProductsByIngredientName("Water", 20);
            var vm = JsonConvert.DeserializeObject<ProductListVm>(result);
            vm.ShouldBeOfType<ProductListVm>();
            vm.Products.Count.ShouldBe(20);

        }






    }
}
