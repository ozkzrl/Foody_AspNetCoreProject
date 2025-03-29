using System.Windows.Markup;
using Foody.EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;

public class EfProductDal : GenericRepository<Product>, IProductDal
{
    private readonly FoodyContext _context;
    public EfProductDal(FoodyContext context) : base(context)
    {
        _context=context;
        
    }

    public List<Product> ProductListWithCategory()
    {
        var values= _context.Products.Include(x=>x.Category).ToList();
        return values;
    }
}
