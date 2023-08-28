using AspNetCoreRateLimit;
using Core.Interfaces;
using Infraestructure.Repository;
using Infraestructure.UnitOfWork;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Versioning;

namespace ApiTienda.Extensions;

    public static class ApplicationServiceExtension
    {
        public static void ConfigureCors(this IServiceCollection services)=>services.AddCors(options=>{
            options.AddPolicy("CorsPolicy",builder=>
            builder.AllowAnyOrigin()
            .AllowAnyMethod()
            .AllowAnyHeader());
        });
    }
