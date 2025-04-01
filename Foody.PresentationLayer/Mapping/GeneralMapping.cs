using AutoMapper;
using Foody.PresentationLayer.Concrete;

public class GeneralMapping:Profile
{

    public GeneralMapping()
    {
        
        CreateMap<ResultAboutDto, About>().ReverseMap();
        CreateMap<CreateAboutDto, About>().ReverseMap();
        CreateMap<GetByIdAboutDto, About>().ReverseMap();
        CreateMap<UpdateAboutDto, About>().ReverseMap();

        CreateMap<ResultSliderDto, Slider>().ReverseMap();
        CreateMap<CreateSliderDto, Slider>().ReverseMap();
        CreateMap<GetByIdSliderDto, Slider>().ReverseMap();
        CreateMap<UpdateSliderDto, Slider>().ReverseMap();
    }


}