using Microsoft.Extensions.DependencyInjection;
using System;
using AutoMapper;

namespace Framework.LeadsManager.Application.Mappers
{
    public static class AutoMapperSetup
    {
        public static void AddAutoMapperSetup(this IServiceCollection services)
        { 
            if(services == null)
                throw new ArgumentNullException(nameof(services));
            services.AddAutoMapper(cfg => cfg.AddProfile(new AutoMapper.MappingProfile()),typeof(object));
        }
    }
}
