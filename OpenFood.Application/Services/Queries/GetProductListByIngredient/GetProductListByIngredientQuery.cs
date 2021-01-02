using MediatR;

namespace OpenFood.Application.Services.Queries.GetProductListByIngredient
{
    public class GetProductListByIngredientQuery :  IRequest<ProductListVm>
    {

        public string Ingredient { get; set; }
        public int Limit { get; set; }

    }
}
