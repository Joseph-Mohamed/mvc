using Demo.BLL.Servies.Classes;
using Demo.BLL.Servies.Interfaces;
using Demo.DataAccessesLayer.Data.Contexts;
using Demo.DataAccessesLayer.Data.Repository.Classes;
using Demo.DataAccessesLayer.Data.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Demo.Presentation
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            //life time [objects] ==> AddScoped ,AddSingeltion , AddTranisent
            builder.Services.AddScoped<ApplicationDBContext>();
            //AddDbContext ==> Allow di dbcontext
            //builder.Services.AddDbContext<ApplicationDBContext>
            //    builder.Services.AddDbContext<ApplicationDBContext>(GetConnectionString("DefaultConnectionString"))

            builder.Services.AddScoped<IDepartementRepository, DepartementRepository>();
            builder.Services.AddScoped<IDepartementServices, DepartementServices>();

            builder.Services.AddDbContext<ApplicationDBContext>(options =>
             options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnectionString")));
            //(options =>
            //    {
            //        //options.UseSqlServer(builder.Configuration["ConnectionStrings:DefaultConnectionString"]);
            //        //options.UseSqlServer(builder.Configuration.GetSection("ConnectionStrings")["DefaultConnectionString"]);


            //        //options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
            //        options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnectionString"));

            //    });
            ////builder.Services.AddDbContext<ApplicationDBContext>(options =>
            //{
            //    //options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
            //    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));

            //});


            //builder.Services.AddScoped<IDepartementRepository, DepartementRepository>();
            builder.Services.AddScoped<IDepartementServices, DepartementServices>();
            // ask u to create object from class implemented IDepartementRepository ==>
            // new instance from DepartementRepository


            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            // btgeb kol el static files at first in wwwrot
            app.UseStaticFiles();
            app.UseRouting();

            //app.UseAuthentication();//login

            //app.UseAuthorization();//Roles

            app.MapStaticAssets();
            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}")
                .WithStaticAssets();

            app.Run();
        }
    }
}


/*
 
 departement module
--> model
==> name , code,decription [properties departent]
==> id,createdby,createdon,modefiedby,modefiedon,isDeleted [soft Delete delete in UI but not in DB ] ==> (All modelues) ==> (parent class)
 */