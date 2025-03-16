public class EfSliderDal : GenericRepository<Slider>, ISliderDal
{
    public EfSliderDal(FoodyContext context) : base(context)
    {

        
    }
}