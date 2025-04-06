using Foody.EntityLayer.Concrete;

public class EfSliderDal : GenericRepository<Slider>, ISliderDal
{
    public EfSliderDal(FoodyContext context) : base(context)
    {

        
    }
}