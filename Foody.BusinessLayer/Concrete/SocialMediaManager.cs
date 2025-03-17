using Foody.EntityLayer.Concrete;

public class SocialMediaManager : ISocialMediaService
{   
    private readonly ISocialMediaDal _socialMediaDal;

    public SocialMediaManager(ISocialMediaDal socialMediaDal)
    {
        _socialMediaDal=socialMediaDal;
    }
    
    public void Add(SocialMedia entity)
    {
        throw new NotImplementedException();
    }

    public void Delete(int id)
    {
        throw new NotImplementedException();
    }

    public List<SocialMedia> GetAll()
    {
        throw new NotImplementedException();
    }

    public SocialMedia GetById(int id)
    {
        throw new NotImplementedException();
    }

    public void Update(SocialMedia entity)
    {
        throw new NotImplementedException();
    }
}