using Foody.EntityLayer.Concrete;

public class AddressManager : IAddressService
{
    private readonly IAddressDal _addressDal;

    public AddressManager(IAddressDal addressDal)
    {
            _addressDal=addressDal;

    }
public void Add(Address entity)
    {
        _addressDal.Add(entity);
    }

    public void Delete(int id)
    {
           _addressDal.Delete(id);
    }

    public List<Address> GetAll()
    {
        return _addressDal.GetAll();
    }

    public Address GetById(int id)
    {
        return _addressDal.GetById(id);
    }

    public void Update(Address entity)
    {
        _addressDal.Update(entity);
    }
}