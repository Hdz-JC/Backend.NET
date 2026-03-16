using System;
using AutoMapper;
using ECommerce.Models;
using ECommerce.Models.Dtos;

namespace ECommerce.Mapping;

public class ProductProfile : Profile
{
    public ProductProfile()
    {
        CreateMap<Product, ProductDto>().ReverseMap();
        CreateMap<Product, CreateProductDto>().ReverseMap();
        CreateMap<Product, UpdateProductDto>().ReverseMap();
    }
}
