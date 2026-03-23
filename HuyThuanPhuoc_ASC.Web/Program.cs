using ASC.Business.Interfaces;
using ASC.Business.Services;
using ASC.DataAccess.Context;
using ASC.DataAccess.UnitOfWork;
using HuyThuanPhuoc_ASC.Web.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.Configure<ApplicationSettings>(
    builder.Configuration.GetSection("ApplicationSettings"));

builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
builder.Services.AddScoped<IServiceRequestService, ServiceRequestService>();
builder.Services.AddScoped<IProductService, ProductService>();

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var context = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();

    if (!context.ServiceRequests.Any())
    {
        context.ServiceRequests.AddRange(
            new ASC.Model.Domain.ServiceRequest
            {
                CustomerName = "Nguyen Van A",
                VehicleNumber = "51A-12345",
                ServiceType = "Engine Maintenance",
                Status = "Pending",
                CreatedBy = "System",
                CreatedDate = DateTime.Now
            },
            new ASC.Model.Domain.ServiceRequest
            {
                CustomerName = "Tran Thi B",
                VehicleNumber = "30H-67890",
                ServiceType = "Oil Change",
                Status = "In Progress",
                CreatedBy = "System",
                CreatedDate = DateTime.Now
            },
            new ASC.Model.Domain.ServiceRequest
            {
                CustomerName = "Le Van C",
                VehicleNumber = "43A-24680",
                ServiceType = "Brake Inspection",
                Status = "Completed",
                CreatedBy = "System",
                CreatedDate = DateTime.Now
            }
        );

        context.SaveChanges();
    }

    if (!context.Products.Any())
    {
        context.Products.AddRange(
            new ASC.Model.Domain.Product
            {
                ProductName = "Engine Oil",
                ProductCode = "PRD001",
                Price = 350000,
                Quantity = 20,
                CreatedBy = "System",
                CreatedDate = DateTime.Now
            },
            new ASC.Model.Domain.Product
            {
                ProductName = "Brake Pad Set",
                ProductCode = "PRD002",
                Price = 850000,
                Quantity = 12,
                CreatedBy = "System",
                CreatedDate = DateTime.Now
            },
            new ASC.Model.Domain.Product
            {
                ProductName = "Air Filter",
                ProductCode = "PRD003",
                Price = 250000,
                Quantity = 30,
                CreatedBy = "System",
                CreatedDate = DateTime.Now
            }
        );

        context.SaveChanges();
    }
}

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();