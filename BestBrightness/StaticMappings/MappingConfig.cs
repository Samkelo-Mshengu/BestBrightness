using AutoMapper;
using DataLogic.Product;
using ViewLogic.Product;

namespace BestBrightness.StaticMappings
{
    public static class ObjectMappings
    {
        private static readonly Lazy<IMapper> _mapper = new (() =>
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<ProductModel, ProductView>().ReverseMap();
            });
            var mapper = config.CreateMapper();
            return mapper;
        });
        public static IMapper Mapper => _mapper.Value;
    }
}
