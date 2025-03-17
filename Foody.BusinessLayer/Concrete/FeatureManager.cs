
public class FeatureManager : IFeatureService
{
    private readonly IFeatureDal _featureDal;
    public FeatureManager(IFeatureDal featureDal)
    {
            _featureDal=featureDal;

    }
    
    public void Add(Feature entity)
    {
        _featureDal.Add(entity);
    }

    public void Delete(int id)
    {
        _featureDal.Delete(id);
    }

    public List<Feature> GetAll()
    {
        return _featureDal.GetAll();
    }

    public Feature GetById(int id)
    {
        return _featureDal.GetById(id);
    }

    public void Update(Feature entity)
    {
        _featureDal.Update(entity);
    }
}