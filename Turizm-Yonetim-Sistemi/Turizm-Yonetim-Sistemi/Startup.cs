using Microsoft.AspNetCore.Builder;
using Turizm_Yonetim_Sistemi.BusinessLayer.Abstract;
using Turizm_Yonetim_Sistemi.BusinessLayer.Concrete;
using Turizm_Yonetim_Sistemi.DataAccessLayer.Abstract;
using Turizm_Yonetim_Sistemi.DataAccessLayer.Concrete.EntityFramework;

namespace Turizm_Yonetim_Sistemi
{
    public class Startup
    {
        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<IMusteriDal, EfMusteriDal>();
            services.AddScoped<IPersonelDal, EfPersonelDal>();
            services.AddScoped<IRotaBilgisiDal, EfRotaBilgisiDal>();
            services.AddScoped<ISeferDal, EfSeferDal>();

            services.AddScoped<IMusteriService, MusteriManager>();
            services.AddScoped<IPersonelService, PersonelManager>();
            services.AddScoped<IRotaBilgisiService, RotaBilgisiManager>();
            services.AddScoped<ISeferService, SeferManager>();
            services.AddControllers();
        }

        public void Configure(WebApplication app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();
            app.UseRouting();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
