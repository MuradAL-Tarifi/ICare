
﻿using ICare.Core.ICommon;
using ICare.Core.IRepository;
using ICare.Core.IServices;
using ICare.Infra.Common;
using ICare.Infra.Repository;
using ICare.Infra.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ICare.API.Extension
{
    public static class DependencyInjectionExtension
    {

        public static void DependencyInjection(this IServiceCollection services /*,IConfiguration configuration*/)
        {

            //DbContext
            services.AddTransient<IDbContext, DbContext>();



            //Repository
            services.AddScoped<IHealthReportRepository, HealthReportRepository>();
            services.AddScoped<IHealthReportTypesRepository, HealthReportTypesRepository>();
            services.AddSingleton<INotificationRepository, NotificationRepository>();
            services.AddScoped<INotificationTypesRepository, NotificationTypesRepository>();
            services.AddScoped<IPatientRepository, PatientRepository>();
            services.AddScoped<ISubscriptionRepository, SubscriptionRepository>();
            services.AddScoped<ISubscriptionTypeRepository, SubscriptionTypeRepository>();
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IUserRolesRepository, UserRolesRepository>();
            services.AddScoped<IUserTokensRepository, UserTokensRepository>();
            services.AddScoped<IUserLoginsRepository, UserLoginsRepository>();
            services.AddScoped<IEmployessRepository, EmployessRepository>();
            services.AddScoped<IAuthRespository, AuthRespository>();
            services.AddScoped<IPatientDrugsRepository, PatientDrugsRepository>(); 
            services.AddScoped<IScheduleEnumRepository, ScheduleEnumRepository>(); 
            services.AddScoped<IDrugDoseTimeRepository, DrugDoseTimeRepository>();
            services.AddScoped<ICartRepository, CartRepository>();
            services.AddScoped<IDeliveryRepository, DeliveryRepository>();
            services.AddScoped<IDrugCategoryRepository, DrugCategoryRepository>();
            services.AddScoped<IDrugRepository, DrugRepository>();
            services.AddScoped<IOrderDrugsRepository, OrderDrugsRepository>();
            services.AddScoped<IOrderRepository, OrderRepository>();//
            services.AddSingleton<IWorkRepository, WorkRepository>();
            services.AddScoped<IOrderRepository, OrderRepository>();
            services.AddScoped<ILocationRepository, LocationRepository>();
            services.AddScoped<IWaterRepository, WaterRepository>();
            services.AddScoped<ITestimonialRepository, TestimonialRepository>();
            services.AddScoped<IAccountantRepository, AccountantRepository>();
            services.AddScoped<IRefreshTokenRepository, RefreshTokenRepository>();
            services.AddSingleton<IProcessBackgroundRepository, ProcessBackgroundRepository>();




            //Services
            services.AddScoped<IHealthReportServices, HealthReportServices>();
            services.AddScoped<IHealthReportTypesServices, HealthReportTypesServices>();
            services.AddSingleton<INotificationServices, NotificationServices>();
            services.AddScoped<INotificationTypesServices, NotificationTypesServices>();
            services.AddScoped<IPatientServices, PatientServices>();
            services.AddScoped<ISubscriptionServices, SubscriptionServices>();
            services.AddScoped<ISubscriptionTypeServices, SubscriptionTypeServices>();
            services.AddScoped<IUserServices, UserServices>();
            services.AddScoped<IUserRolesServices, UserRolesServices>();
            services.AddScoped<IUserTokensServices, UserTokensServices>();
            services.AddScoped<IUserLoginsServices, UserLoginsServices>();
            services.AddScoped<IEmployessServices, EmployessServices>();
            services.AddScoped<IAuthService, AuthService>();
            services.AddScoped<IDrugDoseTimeServices, DrugDoseTimeServices>();
            services.AddScoped<IPatientDrugsServices, PatientDrugsServices>();
            services.AddScoped<IScheduleEnumServices, ScheduleEnumServices>();
            services.AddScoped<ICartService, CartService>();
            services.AddScoped<IDeliveryService, DeliveryService>();
            services.AddScoped<IOrderDrugsService, OrderDrugsService>();
            services.AddScoped<IDrugCategoryService, DrugCategoryService>();
            services.AddScoped<IDrugService, DrugService>();
            services.AddScoped<IOrderService, OrderService>();
            services.AddScoped<IFileService, FileService>();
            services.AddScoped<IPasswordHashingService, PasswordHashingService>();
            services.AddSingleton<IProcessBackgroundService, ProcessBackgroundService>();
            services.AddSingleton<IMailingService, MailingService>();//
            services.AddSingleton<IWorkService, WorkService>();
            services.AddScoped<ILocationSevices, LocationSevices>();
            services.AddScoped<IWaterServices, WaterServices>();
            services.AddTransient<IResetPasswordServices, ResetPasswordServices>();
            services.AddSingleton<IEmailServices, EmailServices>();
            services.AddScoped<ITestimonialService, TestimonialService>();
            services.AddScoped<IAccountantService, AccountantService>();
            services.AddHttpClient();
            services.AddScoped<IEmailServices, EmailServices>();
            services.AddScoped<ITokenService, TokenService>();
            services.AddScoped<IRefreshTokenServices, RefreshTokenServices>();
            services.AddScoped<ISocialLoginAndRegistrationService, SocialLoginAndRegistrationService>();


        }
    }
}
