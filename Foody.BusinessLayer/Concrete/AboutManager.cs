
public class AboutManager : IAboutService
{

    private readonly IAboutdal _aboutDal;

    public AboutManager(IAboutdal aboutDal)
    {
        _aboutDal=aboutDal;
    }

    public void TAdd(About entity)
    {
        _aboutDal.Add(entity);
    }

    public void TDelete(int id)
    {
        _aboutDal.Delete(id);
    }

    public List<About> TGetAll()
    {
        return _aboutDal.GetAll();
    }

    public About TGetById(int id)
    {
        return _aboutDal.GetById(id);
    }

    public void TUpdate(About entity)
    {
        _aboutDal.Update(entity);
    }
}