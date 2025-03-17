
public class AboutManager : IAboutService
{

    private readonly IAboutdal _aboutDal;

    public AboutManager(IAboutdal aboutDal)
    {
        _aboutDal=aboutDal;
    }

    public void Add(About entity)
    {
        _aboutDal.Add(entity);
    }

    public void Delete(int id)
    {
        _aboutDal.Delete(id);
    }

    public List<About> GetAll()
    {
        return _aboutDal.GetAll();
    }

    public About GetById(int id)
    {
        return _aboutDal.GetById(id);
    }

    public void Update(About entity)
    {
        _aboutDal.Update(entity);
    }
}