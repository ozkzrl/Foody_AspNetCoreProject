using Foody.DataAccessLayer.Abstract;


public class GenericRepository<T> : IGenericDal<T> where T : class
{
    private readonly FoodyContext _context;
    
    public GenericRepository(FoodyContext context)
    {

        _context=context;
    }

    public void Update(T entity)
    {
          _context.Set<T>().Update(entity);
          _context.SaveChanges();


    }

     public void Add(T entity)
    {
        _context.Set<T>().Add(entity);
        _context.SaveChanges();
    }


    public List<T> GetAll()
    {
        return _context.Set<T>().ToList();

    }

    public T GetById(int id)
    {
       return _context.Set<T>().Find(id);
    }

    public void Delete(int id)
    {
        var entity = _context.Set<T>().Find(id);
    if (entity != null)
    {
        _context.Set<T>().Remove(entity);
        _context.SaveChanges();
    }
    }
}