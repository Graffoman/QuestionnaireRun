using AutoMapper;
using Domain.Entities.Classes;
using Services.Contracts.QuestionnaireSubmitDto;

namespace Services.Implementations.Mapping
{
    public class QuestionnaireSubmitMappingsProfile : Profile
    {
        public QuestionnaireSubmitMappingsProfile()
        {
            CreateMap<CreateQuestionnaireSubmitDto, QuestionnaireSubmit>()
               .ForMember(x => x.Id, map => map.Ignore())
               .ForMember(x => x.User, map => map.MapFrom(src => src.User))
               .ForMember(x => x.Author, map => map.MapFrom(src => src.Author))
               .ForMember(x => x.QuestionnaireRun, map => map.MapFrom(src => src.QuestionnaireRun))
               .ForMember(x => x.SubmitDate, map => map.MapFrom(src => DateTime.Now))
               .ForMember(x => x.Answers, map => map.MapFrom(src => src.Answers));

            CreateMap<UpdateQuestionnaireSubmitDto, QuestionnaireSubmit>()
               .ForMember(x => x.Id, map => map.Ignore())
               .ForMember(x => x.User, map => map.MapFrom(src => src.User))
               .ForMember(x => x.Author, map => map.MapFrom(src => src.Author))
               .ForMember(x => x.QuestionnaireRun, map => map.MapFrom(src => src.QuestionnaireRun))
               .ForMember(x => x.SubmitDate, map => map.MapFrom(src => src.SubmitDate))
               .ForMember(x => x.Answers, map => map.MapFrom(src => src.Answers));
        }
    }
}
