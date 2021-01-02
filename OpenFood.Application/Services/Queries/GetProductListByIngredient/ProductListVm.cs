using OpenFood.Domain.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace OpenFood.Application.Services.Queries.GetProductListByIngredient
{
    [DataContract]
    public class ProductListVm
    {
        [DataMember(Name = "products")]
        public IList<Product> Products { get; set; }
    }
}
