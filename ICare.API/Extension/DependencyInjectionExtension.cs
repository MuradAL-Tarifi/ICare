﻿using ICare.Core.ICommon;
using ICare.Core.IRepository;
using ICare.Core.IServices;
using ICare.Infra.Common;
using ICare.Infra.Repository;
using ICare.Infra.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ICare.API.Extension
{
    public static class DependencyInjectionExtension
    {

        public static void DependencyInjection(this IServiceCollection services)
        {

            //DbContext
            services.AddScoped<IDbContext, DbContext>();

            //Repository
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IUserRolesRepository, UserRolesRepository>();


            //Services
            services.AddScoped<IUserServices, UserServices>();
            services.AddScoped<IUserRolesServices, UserRolesServices>();


        }
    }
}
