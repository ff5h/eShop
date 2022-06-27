using AutoMapper;
using eShop.API.BLL.DTOs;
using eShop.API.DAL.Entities;

namespace eShop.API.BLL.MapperProfiles
{
    public class ProductMapperProfile : Profile
    {
        public ProductMapperProfile()
        {
            CreateMap<NewProductRequestDto, Product>();
            CreateMap<Product, ProductDto>();
        }
    }
}
