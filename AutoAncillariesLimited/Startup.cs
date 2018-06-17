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
      services.AddSingleton<ICategoryRepository, CategoryRepository>();
      services.AddSingleton<ICustomerRepository, CustomerRepository>();
      services.AddSingleton<IExportBillRepository, ExportBillRepository>();
      services.AddSingleton<IExportBillDetailRepository, ExportBillDetailRepository>();
      services.AddSingleton<IExportInvoiceRepository, ExportInvoiceRepository>();
      services.AddSingleton<IExportInvoiceDetailRepository, ExportInvoiceDetailRepository>();
      services.AddSingleton<IImportBillRepository, ImportBillRepository>();
      services.AddSingleton<IImportBillDetailRepository, ImportBillDetailRepository>();
      services.AddSingleton<IImportInvoiceRepository, ImportInvoiceRepository>();
      services.AddSingleton<IImportInvoiceDetailRepository, ImportInvoiceDetailRepository>();
      services.AddSingleton<IProductPromotionRepository, ProductPromotionRepository>();
      services.AddSingleton<IProductRepository, ProductRepository>();
      services.AddSingleton<IPromotionRepository, PromotionRepository>();
      services.AddSingleton<IProductRateRepository, ProductRateRepository>();
      services.AddSingleton<IRoleRepository, RoleRepository>();
      services.AddSingleton<ISupplierRepository, SupplierRepository>();
      services.AddSingleton<IUserRepository, UserRepository>();
      services.AddSingleton<IUserRoleRepository, UserRoleRepository>();
      services.AddSingleton<IWarehouseRepository, WarehouseRepository>();
      services.AddSingleton<IWarehouseDetailRepository, WarehouseDetailRepository>();
    }
  }
}