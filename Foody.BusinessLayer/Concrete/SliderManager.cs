
using System.ComponentModel;

public class SliderManager : ISliderService
{
    private readonly ISliderDal _sliderDal;

    public SliderManager(ISliderDal sliderDal)
    {
        _sliderDal=sliderDal;
        
    }

    public void TAdd(Slider entity)
    {
        _sliderDal.Add(entity);
    }

    public void TDelete(int id)
    {
        _sliderDal.Delete(id);
    }

    public List<Slider> TGetAll()
    {
        return _sliderDal.GetAll();
    }

    public Slider TGetById(int id)
    {
        return _sliderDal.GetById(id);
    }

    public void TUpdate(Slider entity)
    {
         _sliderDal.Update(entity);
    }
}