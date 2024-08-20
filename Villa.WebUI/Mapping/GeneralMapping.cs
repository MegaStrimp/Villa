using AutoMapper;
using Villa.Dto.Dtos.BannerDtos;
using Villa.Dto.Dtos.ContactDtos;
using Villa.Dto.Dtos.CounterDtos;
using Villa.Dto.Dtos.DealDtos;
using Villa.Dto.Dtos.FeatureDtos;
using Villa.Dto.Dtos.MessageDtos;
using Villa.Dto.Dtos.ProductDtos;
using Villa.Dto.Dtos.QuestDtos;
using Villa.Dto.Dtos.SubHeaderDtos;
using Villa.Dto.Dtos.VideoDtos;
using Villa.Entity.Entities;

namespace Villa.WebUI.Mapping
{
    public class GeneralMapping : Profile
    {
        public GeneralMapping()
        {
            CreateMap<CreateBannerDto, Banner>().ReverseMap();
            CreateMap<ResultBannerDto, Banner>().ReverseMap();
            CreateMap<UpdateBannerDto, Banner>().ReverseMap();

            CreateMap<CreateContactDto, Contact>().ReverseMap();
            CreateMap<ResultContactDto, Contact>().ReverseMap();
            CreateMap<UpdateContactDto, Contact>().ReverseMap();

            CreateMap<CreateCounterDto, Counter>().ReverseMap();
            CreateMap<ResultCounterDto, Counter>().ReverseMap();
            CreateMap<UpdateCounterDto, Counter>().ReverseMap();

            CreateMap<CreateDealDto, Deal>().ReverseMap();
            CreateMap<ResultDealDto, Deal>().ReverseMap();
            CreateMap<UpdateDealDto, Deal>().ReverseMap();

            CreateMap<CreateFeatureDto, Feature>().ReverseMap();
            CreateMap<ResultFeatureDto, Feature>().ReverseMap();
            CreateMap<UpdateFeatureDto, Feature>().ReverseMap();

            CreateMap<CreateMessageDto, Message>().ReverseMap();
            CreateMap<ResultMessageDto, Message>().ReverseMap();
            CreateMap<UpdateMessageDto, Message>().ReverseMap();

            CreateMap<CreateProductDto, Product>().ReverseMap();
            CreateMap<ResultProductDto, Product>().ReverseMap();
            CreateMap<UpdateProductDto, Product>().ReverseMap();

            CreateMap<CreateQuestDto, Quest>().ReverseMap();
            CreateMap<ResultQuestDto, Quest>().ReverseMap();
            CreateMap<UpdateQuestDto, Quest>().ReverseMap();

            CreateMap<CreateVideoDto, Video>().ReverseMap();
            CreateMap<ResultVideoDto, Video>().ReverseMap();
            CreateMap<UpdateVideoDto, Video>().ReverseMap();

            CreateMap<CreateSubHeaderDto, SubHeader>().ReverseMap();
            CreateMap<ResultSubHeaderDto, SubHeader>().ReverseMap();
            CreateMap<UpdateSubHeaderDto, SubHeader>().ReverseMap();
        }
    }
}
