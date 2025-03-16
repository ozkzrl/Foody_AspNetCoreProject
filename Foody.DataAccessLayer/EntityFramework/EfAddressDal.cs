using Foody.EntityLayer.Concrete;

public class EfAddressDal : GenericRepository<Address>,IAddressDal
{
    public EfAddressDal(FoodyContext context) : base(context)
    {



    }
}