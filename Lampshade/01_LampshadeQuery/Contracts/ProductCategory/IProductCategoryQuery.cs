using System.Collections.Generic;
using ShopManagement.Application.Contracts.ProductCategory;

namespace _01_LampshadeQuery.Contracts.ProductCategory
{
    public interface IProductCategoryQuery
    {
        List<ProductCategoryQueryModel> GetProductCategories();
    }
}