
using ASC.Model.Models;
using AutoMapper;

namespace ASC.Web.Areas.Configuration.Models
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // Domain to ViewModel
            CreateMap<MasterDataKey, MasterDataKeyViewModel>();
            CreateMap<MasterDataValue, MasterDataValueViewModel>();
            CreateMap<MasterDataKeyViewModel, MasterDataKey>();
            CreateMap<MasterDataValueViewModel, MasterDataValue>();
        }
    }
}
