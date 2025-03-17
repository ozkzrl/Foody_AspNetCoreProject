
using System.ComponentModel;

public class SliderManager : ISliderService
{
    private readonly ISliderDal _sliderDal;

    public SliderManager(ISliderDal sliderDal)
    {
        _sliderDal=sliderDal;
        
    }

    public void Add(Slider entity)
    {
        _sliderDal.Add(entity);
    }

    public void Delete(int id)
    {
        _sliderDal.Delete(id);
    }

    public List<Slider> GetAll()
    {
        return _sliderDal.GetAll();
    }

    public Slider GetById(int id)
    {
        return _sliderDal.GetById(id);
    }

    public void Update(Slider entity)
    {
         _sliderDal.Update(entity);
    }
}