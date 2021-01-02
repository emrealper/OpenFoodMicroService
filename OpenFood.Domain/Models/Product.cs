using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;
using System.Linq;

namespace OpenFood.Domain.Models
{

    [DataContract]
    public class Product
    {

       
        [DataMember(Name ="product_name")]
        public string productName { get; set; }



        [DataMember(Name = "ingredients")]
        [JsonIgnore()]
        public List<Ingredient> ingredients { get; set; }

        [DataMember(Name = "listOfIngredients")]
        public IEnumerable<string> ingredientList
        {
           get
            {
                return ingredients.Select(x => x.Text).ToArray();
            }
        }


    }
}
