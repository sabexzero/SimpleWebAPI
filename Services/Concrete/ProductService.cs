public class ProductService : IProductService
{
    private readonly IProductRepository _repository;
    public ProductService(IProductRepository repository)
    {
        _repository = repository;
    }

    public async Task Create(Product entity)
    {
        await _repository.Create(entity);
    }

    public async Task<bool> Delete(int id)
    {
        return await _repository.Delete(id);
    }

    public async Task<Product> Get(int id)
    {
        return await _repository.Get(id);
    }

    public async Task SaveChangesAsync()
    {
        await _repository.SaveChangesAsync();
    }

    public async Task<IEnumerable<Product>> Select()
    {
        return await _repository.Select();
    }
}
