using AutoMapper;
using SignalR.Api.DAL.Entities;
using SignalR.DtoLayer.ProductDto;

namespace SignalR.Api.Mapping
{
    public class ProductMapping:Profile
    {
        public ProductMapping()
        {
            CreateMap<Product, ResultProductDto>().ReverseMap();
            CreateMap<Product, CreateProductDto>().ReverseMap();
            CreateMap<Product, UpdateProductDto>().ReverseMap();
            CreateMap<Product, GetProductDto>().ReverseMap();
            CreateMap<Product, ResultProdcutWithCategoryDto>().ReverseMap();
        }
    }
}
