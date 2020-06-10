using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AuthorizationClassLibrary;
using AuthorizationClassLibrary.AuthUtils;
using AuthorizationClassLibrary.Repositories;
using DiaryClassDataLayer;
using DiaryClassDataLayer.Repositories;
using DiaryOnlineAdmin.ModelBuilders;
using DiaryOnlineAdmin.Repositories;
using DiaryOnlineAdmin.Utils;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace DiaryOnlineAdmin
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();

            services.AddDbContext<UsersContext>(options => options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
            services.AddDbContext<DiaryContext>(options => options.UseSqlServer(Configuration.GetConnectionString("diarycontext")));

            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
                           .AddCookie(options =>
                           {
                               options.LoginPath = new Microsoft.AspNetCore.Http.PathString("/Admin/Login");
                               options.AccessDeniedPath = new Microsoft.AspNetCore.Http.PathString("/Admin/Login");
                               
                           });
            //Подключаем модули тут
            services.AddScoped<ILoginUtil , LoginUtil>();
            services.AddScoped<IUsersRepository , UsersRepository>();
            services.AddScoped<IUsersModelBuilder , UsersModelBuilder>();
            services.AddScoped<IRolesRepository , RolesRepository>();
            services.AddScoped<IAdministrationUsersUtil , AdministrationUsersUtil>();
            services.AddScoped<ISubjectsRepository , SubjectsRepository>();
            services.AddScoped<IInfoRepository , InfoRepository>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app)
        {
          
            app.UseHttpsRedirection(); 
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();   
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}");
            });
        }
    }
}
