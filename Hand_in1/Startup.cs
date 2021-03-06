using System.Security.Claims;
using Hand_in1.Authentication;
using Hand_in1.Data;
using Hand_in1.Data.Impl;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.AspNetCore.Components.Authorization;
using Syncfusion.Blazor;

namespace Hand_in1
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddRazorPages();
            services.AddServerSideBlazor();
            services.AddScoped<IAdultService, WebAdultService>();
            services.AddScoped<IUserService, WebUserService>();
            services.AddScoped<AuthenticationStateProvider, CustomAuthenticationStateProvider>();
            services.AddSyncfusionBlazor();

            services.AddAuthorization(options =>
            {
                options.AddPolicy("SecurityLevel3", a => a.RequireAuthenticatedUser()
                    .RequireClaim("SecurityLevel", "3"));
                
                options.AddPolicy("CanDeleteAdults", a => a.RequireAuthenticatedUser()
                    .RequireClaim("Role", "Manager"));

                options.AddPolicy("SensitiveInfo", a => a.RequireAuthenticatedUser()
                    .RequireClaim("Role", "Employee", "Manager"));
                
                options.AddPolicy("MustBeUser", a => a.RequireAuthenticatedUser()
                    .RequireClaim("Role", "Customer", "Employee", "Manager"));
                
                options.AddPolicy("SecurityLevel2", a => a.RequireAuthenticatedUser()
                    .RequireAssertion(context =>
                    {
                        Claim levelClaim = context.User.FindFirst(claim => claim.Type.Equals("SecurityLevel"));
                        if (levelClaim == null) return false;
                        return int.Parse(levelClaim.Value) >= 2;
                    }));
                
                options.AddPolicy("SecurityLevel1", a => a.RequireAuthenticatedUser()
                    .RequireAssertion(context =>
                    {
                        Claim levelClaim = context.User.FindFirst(claim => claim.Type.Equals("SecurityLevel"));
                        if (levelClaim == null) return false;
                        return int.Parse(levelClaim.Value) >= 1;
                    }));
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("NTE1Njg5QDMxMzkyZTMzMmUzMGlpTWw5cCt6cjFkMzRCbmtUUmVuUWdRZzFZdlBWOWFweTNPMmNQdVNkeW89");
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapBlazorHub();
                endpoints.MapFallbackToPage("/_Host");
            });
        }
    }
}