using Microsoft.AspNetCore.Mvc;

public class _DefaultSliderSectionComponentPartial : ViewComponent
{
    private readonly ISliderService _sliderService;

    public _DefaultSliderSectionComponentPartial(ISliderService sliderService)
    {
        _sliderService=sliderService;
    }
    public IViewComponentResult Invoke()
    {
        var values=_sliderService.TGetAll();
        return View(values);
    }

}