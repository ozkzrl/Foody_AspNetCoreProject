using Foody.EntityLayer.Concrete;

public class SocialMediaManager : ISocialMediaService
{   
    private readonly ISocialMediaDal _socialMediaDal;

    public SocialMediaManager(ISocialMediaDal socialMediaDal)
    {
        _socialMediaDal=socialMediaDal;
    }
    
    public void TAdd(SocialMedia entity)
    {
        throw new NotImplementedException();
    }

    public void TDelete(int id)
    {
        throw new NotImplementedException();
    }

    public List<SocialMedia> TGetAll()
    {
        throw new NotImplementedException();
    }

    public SocialMedia TGetById(int id)
    {
        throw new NotImplementedException();
    }

    public void TUpdate(SocialMedia entity)
    {
        throw new NotImplementedException();
    }
}