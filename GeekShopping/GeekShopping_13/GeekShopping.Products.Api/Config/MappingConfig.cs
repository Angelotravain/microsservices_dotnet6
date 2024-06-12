using AutoMapper;
using GeekShopping.Products.Api.Data.ValueObjects;
using GeekShopping.Products.Api.Model;

namespace GeekShopping.Products.Api.Config
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<ProductVo, Product>();
                config.CreateMap<Product, ProductVo>();
            });

            return mappingConfig;
        }
    }
}
