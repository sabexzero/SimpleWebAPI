using Microsoft.EntityFrameworkCore;
#pragma warning disable
public class ProductRepository : IProductRepository
{
    private readonly ProductContext _context;
    public ProductRepository(ProductContext context)
    {
        _context = context;
    }
    public async Task SaveChangesAsync()
    {
        await _context.SaveChangesAsync();
    }

    public async Task Create(Product entity)
    {
        await _context.Set<Product>().AddAsync(entity);
    }

    public async Task<bool> Delete(int id)
    {
        if (id > 0)
        {
            var deleted = await _context.Set<Product>().FirstOrDefaultAsync(s => s.Id == id);
            if (deleted != null)
            {
                _context.Set<Product>().Remove(deleted);
                return true;
            }
        }
        return false;
    }

    public async Task<Product> Get(int id)
    {
        return await _context.Set<Product>().FirstOrDefaultAsync(s => s.Id == id);
    }

    public async Task<Product> GetByTitle(string title)
    {
        return await _context.Set<Product>().FirstOrDefaultAsync(s => s.Title == title);
    }

    public async Task<IEnumerable<Product>> Select()
    {
        return await _context.Set<Product>().ToListAsync();
    }
}