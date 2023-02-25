using need.Models.Abstract;

public interface IProductRepository : IBaseRepository<Product>
{
    Task<Product> GetByTitle(string title);

}