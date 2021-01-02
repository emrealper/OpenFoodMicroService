using OpenFood.Application.Services.Queries.GetProductListByIngredient;
using Shouldly;
using Xunit;

namespace Application.UnitTests.Services.Queries.GetProductListByIngredient
{
   public class GetProductListByIngredientQueryValidatorTest
    {



        [Fact]
        public void IsValid_ShouldBeFalse_WhenLimitIsGreaterThan20()
        {
            var query = new GetProductListByIngredientQuery
            {
                Ingredient = "Sugar",
                Limit = 21
            };

            var validator = new GetProductListByIngredientQueryValidator();

            var result = validator.Validate(query);

            result.IsValid.ShouldBe(false);
        }



        [Fact]
        public void IsValid_ShouldBeFalse_WhenIngredientIsNullOrEmpty()
        {
            var query = new GetProductListByIngredientQuery
            {
                Ingredient = "",
                Limit = 20
            };

            var validator = new GetProductListByIngredientQueryValidator();

            var result = validator.Validate(query);

            result.IsValid.ShouldBe(false);
        }
    }
}
