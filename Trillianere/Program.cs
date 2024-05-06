using Microsoft.EntityFrameworkCore;
using Trillianere.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddDbContext<TrillianereStoriesdbContext>(options =>
     options.UseSqlServer(builder.Configuration.GetConnectionString("SupplierDetailsContext") ?? throw new InvalidOperationException("Connection string 'SupplierDetailsContext' not found.")));


builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<TrillianereStoriesdbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("SupplierDetailsContext")));

var app = builder.Build();




// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Stories}/{action=Index}/{id?}");

app.Run();
