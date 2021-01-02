using OpenFood.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace OpenFood.Application.Common.Interfaces
{
    public interface IOpenFoodService
    {

        Task<string> GetProductsByIngredientName(string ingredient,int limit);
    }
}
