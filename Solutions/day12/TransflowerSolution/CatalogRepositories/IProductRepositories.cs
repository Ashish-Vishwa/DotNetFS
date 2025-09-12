namespace CatalogRepositories;

using CatalogEntities;
using System.Collections.Generic;
public interface IProductRepositories
{
    IEnumerable<Product> GetAllProducts();
    Product? GetProductById(int Id);
    void AddProduct(Product product);
    void UpdateProduct(Product product);
    void DeleteProduct(int Id);
}