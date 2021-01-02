using Microsoft.AspNetCore.WebUtilities;
using Microsoft.Extensions.Configuration;
using OpenFood.Application.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace OpenFood.Infrastructure
{
    public class OpenFoodService :IOpenFoodService
    {

        private IConfiguration configuration;


        public OpenFoodService(IConfiguration configuration)
        {

            this.configuration = configuration;

            
        }


        public virtual Task<string> GetProductsByIngredientName(string ingredient, int limit)
        {
            



                using (var client = new HttpClient())
                {

                    client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
                  

               var _params = new Dictionary<string, string>() { { "action", "process" },
                {"tagtype_0",  "ingredients" },
                {"tag_contains_0",  "contains" },
                {"tag_0", ingredient },
                 {"page_size", limit.ToString() },
                 {"json", "true" },


                };
               
                var openFoodFactsApiUrl = new Uri(QueryHelpers.AddQueryString(
                    this.configuration["openFoodFactApiBaseAddress"]
                    , _params));




                HttpResponseMessage response = client.GetAsync(openFoodFactsApiUrl).Result;
                    if (response.IsSuccessStatusCode)
                    {
                        var stringResult = response.Content.ReadAsStringAsync();

                        return Task.FromResult(stringResult.Result);

                    }
                    else
                    {
                        return null;
                    }

                   
                }
            

           

        }

    }
}
