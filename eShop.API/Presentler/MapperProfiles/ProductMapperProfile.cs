using AutoMapper;
using eShop.API.BLL.DTOs;
using eShop.API.Presentler.Contracts;

namespace eShop.API.Presentler.MapperProfiles
{
    public class ProductMapperProfile : Profile
    {
        public ProductMapperProfile()
        {
            CreateMap<ProductDto, ProductContract>();
            CreateMap<NewProductContract, NewProductRequestDto>();
        }
    }
}
