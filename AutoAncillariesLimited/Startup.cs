using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Data;
using Data.Implements;
using Data.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace AutoAncillariesLimited
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
      services.Configure<CookiePolicyOptions>(options =>
      {
        // This lambda determines whether user consent for non-essential cookies is needed for a given request.
        options.CheckConsentNeeded = context => true;
        options.MinimumSameSitePolicy = SameSiteMode.None;
      });

      services.AddDbContext<AALDbContext>();
      services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);


      //Add Repository to DI
      DependencyInjection(services);
    }

    // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
    public void Configure(IApplicationBuilder app, IHostingEnvironment env)
    {
      if (env.IsDevelopment())
      {
        app.UseDeveloperExceptionPage();
      }
      else
      {
        app.UseExceptionHandler("/Home/Error");
        app.UseHsts();
      }

      app.UseHttpsRedirection();
      app.UseStaticFiles();
      app.UseCookiePolicy();

      app.UseMvc(routes =>
      {
        routes.MapRoute(
          name: "default",
          template: "{controller=Home}/{action=Index}/{id?}");
      });
    }

    private static void DependencyInjection(IServiceCollection services)
    {
      services.AddTransient<ICategoryRepository, CategoryRepository>();
      services.AddTransient<ICustomerRepository, CustomerRepository>();
      services.AddTransient<IExportBillRepository, ExportBillRepository>();
      services.AddTransient<IExportBillDetailRepository, ExportBillDetailRepository>();
      services.AddTransient<IExportInvoiceRepository, ExportInvoiceRepository>();
      services.AddTransient<IExportInvoiceDetailRepository, ExportInvoiceDetailRepository>();
      services.AddTransient<IImportBillRepository, ImportBillRepository>();
      services.AddTransient<IImportBillDetailRepository, ImportBillDetailRepository>();
      services.AddTransient<IImportInvoiceRepository, ImportInvoiceRepository>();
      services.AddTransient<IImportInvoiceDetailRepository, ImportInvoiceDetailRepository>();
      services.AddTransient<IProductPromotionRepository, ProductPromotionRepository>();
      services.AddTransient<IProductRepository, ProductRepository>();
      services.AddTransient<IPromotionRepository, PromotionRepository>();
      services.AddTransient<IProductRateRepository, ProductRateRepository>();
      services.AddTransient<IRoleRepository, RoleRepository>();
      services.AddTransient<ISupplierRepository, SupplierRepository>();
      services.AddTransient<IUserRepository, UserRepository>();
      services.AddTransient<IUserRoleRepository, UserRoleRepository>();
      services.AddTransient<IWarehouseRepository, WarehouseRepository>();
      services.AddTransient<IWarehouseDetailRepository, WarehouseDetailRepository>();
    }
  }
}