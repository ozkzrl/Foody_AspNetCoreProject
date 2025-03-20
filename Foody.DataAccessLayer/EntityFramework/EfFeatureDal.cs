public class EfFeatureDal : GenericRepository<Feature>, IFeatureDal
{
    public EfFeatureDal(FoodyContext context) : base(context)
    {

        
    }
}