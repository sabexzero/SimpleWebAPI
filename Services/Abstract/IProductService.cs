public interface IProductService
{
    Task Create(Product entity);
    Task<Product> Get(int id);
    Task<IEnumerable<Product>> Select();
    Task<bool> Delete(int id);
    Task SaveChangesAsync();
}