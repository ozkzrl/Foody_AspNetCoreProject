using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Reflection;



var builder = WebApplication.CreateBuilder(args);

builder.Services.AddAutoMapper(typeof(GeneralMapping));


builder.Services.AddDbContext<FoodyContext>();

builder.Services.AddScoped<ICategoryDal, EfCategoryDal>();
builder.Services.AddScoped<ICategoryService, CategoryManager>();

builder.Services.AddScoped<IProductDal, EfProductDal>();
builder.Services.AddScoped<IProductService, ProductManager>();

builder.Services.AddScoped<ISliderDal, EfSliderDal>();
builder.Services.AddScoped<ISliderService, SliderManager>();

builder.Services.AddScoped<IAboutdal, EfAboutDal>();
builder.Services.AddScoped<IAboutService, AboutManager>();


builder.Services.AddAutoMapper(Assembly.GetExecutingAssembly());


// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();




// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles(); // Statik dosyalar için gerekli

app.UseRouting();
app.UseAuthorization();
app.UseStaticFiles(); // Statik dosyalar için gerekli

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Abouts}/{action=CreateAbout}/{id?}");

app.Run();
