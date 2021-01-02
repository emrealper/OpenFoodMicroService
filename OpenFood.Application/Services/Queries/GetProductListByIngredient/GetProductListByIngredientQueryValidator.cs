using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace OpenFood.Application.Services.Queries.GetProductListByIngredient
{
    public class GetProductListByIngredientQueryValidator : AbstractValidator<GetProductListByIngredientQuery>
    {
        public GetProductListByIngredientQueryValidator()
        {


            RuleFor(x => x.Limit).LessThanOrEqualTo(20);
            RuleFor(x => x.Ingredient).NotNull().NotEmpty();

        }

    }
}
