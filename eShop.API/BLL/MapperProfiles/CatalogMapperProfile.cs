using AutoMapper;
using eShop.API.BLL.DTOs;
using eShop.API.DAL.Entities;

namespace eShop.API.BLL.MapperProfiles
{
    public class CatalogMapperProfile : Profile
    {
        public CatalogMapperProfile()
        {
            CreateMap<Product, ProductDto>();
        }
    }
}
