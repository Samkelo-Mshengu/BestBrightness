using AutoMapper;
using DataLogic.Activity;
using DataLogic.Admin;
using DataLogic.Age;
using DataLogic.Await;
using DataLogic.Branches;
using DataLogic.Countries;
using DataLogic.Events;
using DataLogic.Members;
using DataLogic.Product;
using DataLogic.Provinces;
using DataLogic.Statuses;
using DataLogic.Users;
using ViewLogic.Activity;
using ViewLogic.Admin;
using ViewLogic.Age;
using ViewLogic.Await;
using ViewLogic.Branch;
using ViewLogic.Countries;
using ViewLogic.Events;
using ViewLogic.Members;
using ViewLogic.Product;
using ViewLogic.Provinces;
using ViewLogic.Statuses;
using ViewLogic.User;

namespace BestBrightness.StaticMappings
{
    public static class ObjectMappings
    {
        private static readonly Lazy<IMapper> _mapper = new (() =>
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<ProductModel, ProductView>().ReverseMap();
                cfg.CreateMap<Branch, BranchView>().ReverseMap();
                cfg.CreateMap<ActivityHistory, ActivityHistoryView>().ReverseMap();
                cfg.CreateMap<AgeGroup, AgeGroupView>().ReverseMap();
                cfg.CreateMap<Awaiting, AwaitingView>().ReverseMap();
                cfg.CreateMap<County, CountryView>().ReverseMap();
                cfg.CreateMap<Event, EventView>().ReverseMap();
                cfg.CreateMap<MemberModel, MemberView>().ReverseMap();
                cfg.CreateMap<Province, ProvinceView>().ReverseMap();
                cfg.CreateMap<Status, StatusView>().ReverseMap();
                cfg.CreateMap<SuperAdmin, SuperAdminView>().ReverseMap();
                cfg.CreateMap<User, UserView>().ReverseMap();
            });
            var mapper = config.CreateMapper();
            return mapper;
        });
        public static IMapper Mapper => _mapper.Value;
    }
}
