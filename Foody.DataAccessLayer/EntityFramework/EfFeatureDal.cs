public class EfFeatureDal : GenericRepository<Feature>, IFeaturDal
{
    public EfFeatureDal(FoodyContext context) : base(context)
    {

        
    }
}