using AutoMapper;
using Domain.Entities.Classes;
using Domain.Entities.Enums;
using Services.Contracts.QuestionnaireRunDto;


namespace Services.Implementations.Mapping
{
    public class QuestionnaireRunMappingsProfile : Profile
    {
        public QuestionnaireRunMappingsProfile()
        {
            CreateMap<CreateQuestionnaireRunDto, QuestionnaireRun>()
                .ForMember(x => x.Id, map => map.Ignore())
                .ForMember(x => x.QuestionnaireId, map => map.MapFrom(src => src.QuestionnaireId))
                .ForMember(x => x.State, map => map.MapFrom(src => QuestionnaireRunState.New))
                .ForMember(x => x.StartDate, map => map.MapFrom(src => DateTime.Now))
                .ForMember(x => x.EndDate, map => map.MapFrom(src => DateTime.Now))
                .ForMember(x => x.SendDate, map => map.MapFrom(src => src.SendDate))
                .ForMember(x => x.User, map => map.MapFrom(src => src.User))
                .ForMember(x => x.UserGroup, map => map.MapFrom(src => src.UserGroup))
                .ForMember(x => x.Author, map => map.MapFrom(src => src.Author));

            CreateMap<UpdateQuestionnaireRunDto, QuestionnaireRun>()

                .ForMember(x => x.Id, map => map.Ignore())
                .ForMember(x => x.QuestionnaireId, map => map.MapFrom(src => src.QuestionnaireId))
                .ForMember(x => x.State, map => map.MapFrom(src => src.State))
                .ForMember(x => x.StartDate, map => map.MapFrom(src => src.StartDate))
                .ForMember(x => x.EndDate, map => map.MapFrom(src => src.EndDate))
                .ForMember(x => x.SendDate, map => map.MapFrom(src => src.SendDate))
                .ForMember(x => x.User, map => map.MapFrom(src => src.User))
                .ForMember(x => x.UserGroup, map => map.MapFrom(src => src.UserGroup))
                .ForMember(x => x.Author, map => map.MapFrom(src => src.Author));

        }
    }
}
