namespace Radcc.Mvc.App_Start
{
    public static class MappingConfig
    {
        public static void RegisterMaps() 
        { 
        AutoMapper.Mapper.Initialize(config =>
        {
            //config.CreateMap<Event, CurrentProgrammeViewModel>().ForMember(dest => dest.EventType, opt => opt.MapFrom(src => src.EventType));

        });
        }
    }
}