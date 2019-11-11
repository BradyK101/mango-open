using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Text.Encodings.Web;
using System.Text.Unicode;
namespace Mango.Web
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
            //services.Configure<CookiePolicyOptions>(options =>
            //{
            //    // This lambda determines whether user consent for non-essential cookies is needed for a given request.
            //    options.CheckConsentNeeded = context => true;
            //});

            services.AddSession();
            services.AddMemoryCache();

            services.AddControllersWithViews(options => {
                //options.Filters.Add(new Extensions.AuthorizationActionFilter());
            }).AddNewtonsoftJson();
            services.AddRazorPages();
            //
            services.AddSingleton(HtmlEncoder.Create(UnicodeRanges.All));
            //���Session��������
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }

            app.UseStaticFiles();

            //���ûỰ�洢(Session)
            app.UseSession();
            app.UseCookiePolicy();

            app.UseAuthorization();

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapAreaControllerRoute(
                   name: "area",
                   areaName: "User",
                   pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}");

                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
                endpoints.MapRazorPages();
            });
            Core.Configuration.AddItem("ApiServerUrl", Configuration.GetSection("ApiServer:ApiServerUrl").Value);
            //��Ѷ������
            Core.Configuration.AddItem("Tencent_VerificationAppId", Configuration.GetSection("Tencent:VerificationAppId").Value);
            Core.Configuration.AddItem("Tencent_VerificationAppSecretKey", Configuration.GetSection("Tencent:VerificationAppSecretKey").Value);
        }
    }
}
