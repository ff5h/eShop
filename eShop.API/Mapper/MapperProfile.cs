using AutoMapper;
using eShop.API.BLL.DTOs;
using eShop.API.Contracts;

namespace eShop.API.Mapper
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<CreateProductContract, ProductDto>();
        }
    }
}
