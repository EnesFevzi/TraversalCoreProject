using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using TraversalProject.BusinessLayer.Extensions;
using TraversalProject.DataAccessLayer.Concrete;
using TraversalProject.DataAccessLayer.Extensions;
using TraversalProject.EntityLayer.Concrete;
using TraversalProject.Extensions;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<DbContext>();
builder.Services.AddIdentity<AppUser, AppRole>().AddEntityFrameworkStores<TContext>().AddDefaultTokenProviders();

//builder.Services.AddFluentValidationAutoValidation();
//builder.Services.AddFluentValidationClientsideAdapters();
builder.Services.AddHttpClient();
builder.Services.AddAuthorization();
builder.Services.LoadDataLayerExtension();
builder.Services.LoadServiceLayerExtension();
builder.Services.LoadWebUILayerExtension();
builder.Services.AddControllersWithViews().AddRazorRuntimeCompilation();
builder.Services.AddAutoMapper(typeof(Program).Assembly);

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
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.MapControllers();
app.Run();
