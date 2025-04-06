
using Foody.EntityLayer.Concrete;

public class FeatureManager : IFeatureService
{
    private readonly IFeatureDal _featureDal;
    public FeatureManager(IFeatureDal featureDal)
    {
            _featureDal=featureDal;

    }
    
    public void TAdd(Feature entity)
    {
        _featureDal.Add(entity);
    }


    public void TDelete(int id)
    {
        _featureDal.Delete(id);
    }

    public List<Feature> TGetAll()
    {
        return _featureDal.GetAll();
    }

    public Feature TGetById(int id)
    {
        return _featureDal.GetById(id);
    }

    public void TUpdate(Feature entity)
    {
        _featureDal.Update(entity);
    }

}