using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MyCurrencyApp.Data;
using MyCurrencyApp.Data.Interfaces;
using MyCurrencyApp.Data.Repository;
using MyCurrencyApp.Models;

namespace MyCurrencyApp
{
    public class Startup
    {
        //Получить данные из строки в dbsettings.json
        private IConfigurationRoot _confString;
        public Startup(IHostingEnvironment hostEnv)
        {
            //получение строки из dbsettings.json
            _confString = new ConfigurationBuilder().SetBasePath(hostEnv.ContentRootPath).AddJsonFile("dbsettings.json").Build();
        }
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<AppDBContent>(options => options.UseSqlServer(_confString.GetConnectionString("DefaultConnection")));

            //теперь когда мы хотим подключить DB наши интерфейсы реализуются подругому 
            //итерфейсы реализуются от классов, которые связанны с DB
            services.AddTransient<IAllCurrencys, CurrencyRepository>();

            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

            services.AddMvc();
            services.AddSwaggerGen();
            //пропишем, что используем кешь и сессии
            services.AddMemoryCache();
            services.AddSession();
        }

        public void Configure(IApplicationBuilder app)
        {
            app.UseDeveloperExceptionPage();//отображать сообщения об ошибках
            app.UseStatusCodePages();//отображать код ошибок
            app.UseStaticFiles();//работать с статическими файлами
            app.UseSession();//используем сессии
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
            });
            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                   name: "default",
                   pattern: "{controller=Home}/{action=Index}/{id?}");
            });

            //app.UseEndpoints(endpoints =>
            //{
            //    endpoints.MapControllers();
            //});

            //подключение к AppDBContent - БД
            using (var scope = app.ApplicationServices.CreateScope())
            {
                AppDBContent content = scope.ServiceProvider.GetRequiredService<AppDBContent>();
                //при старте программы вызвается
                DBObjects.Initial(content);
            };
        }
    }
}