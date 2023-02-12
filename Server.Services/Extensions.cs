using System.Collections.Generic;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Server.Repository;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repository.Interfaces;
using Repository.Repositories;
using Server.Repository.Entities;
using Services.Models;

namespace Services
{
    public static class Extensions
    {
        public static void AddRepoDependencies(this IServiceCollection services)
        {
            services.AddScoped<IUserRepository, UserRepository>();

            MapperConfiguration config = new MapperConfiguration(
               conf => conf.CreateMap<User, UserModel>()
               .ForMember(dest => dest.UserId, opt => opt.MapFrom(dest => dest.UserId))
               .ReverseMap()
               .ForMember(dest => dest.UserId, opt => opt
               .MapFrom(dest => dest.UserId)));
            IMapper mapper = config.CreateMapper();
            services.AddSingleton(mapper);
            services.AddDbContext<IDataSource, Context>();
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

        }
    }
}
