using Microsoft.EntityFrameworkCore;
using Tarakan.BusinessObjects.Helper;
using Tarakan.BusinessObjects.Interface;
using Tarakan.BusinessObjects.Query;
using Tarakan.EntityFramework.Base;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(connectionString));
Helper.initES(connectionString);

builder.Services.AddControllersWithViews();
builder.Services.AddDistributedMemoryCache();

builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromMinutes(15);
    options.Cookie.HttpOnly = true;
    options.Cookie.IsEssential = true;
});

// Add authentication (without Identity)
builder.Services.AddAuthentication("Cookies")
    .AddCookie("Cookies", options =>
    {
        options.LoginPath = "/Home/Login"; // Redirect to custom login page
        options.AccessDeniedPath = "/Home/Login";
    });

//Register Interface Query
builder.Services.AddScoped<IAppUser, AppUser>();
builder.Services.AddScoped<IAppParameter, AppParameter>();
builder.Services.AddScoped<IRegistration, Registration>();
builder.Services.AddScoped<IParamedic, Paramedic>();
builder.Services.AddScoped<IServiceUnit, ServiceUnit>();
builder.Services.AddScoped<IVitalSign, VitalSign>();
builder.Services.AddScoped<IAppStandardReferenceItem, AppStandardReferenceItem>();
builder.Services.AddScoped<IGuarantorBridging, GuarantorBridging>();
builder.Services.AddScoped<ICostCalculation, CostCalculation>();
builder.Services.AddScoped<IMergeBilling, Mergebilling>();
builder.Services.AddScoped<IRegistrationInfoSumary, RegistrationInfoSumary>();

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

// Enable session middleware
app.UseSession();
app.UseAuthentication();
app.UseAuthorization();

app.MapAreaControllerRoute(
    name: "MyTarakan",
    areaName: "Tarakan",
    pattern: "Tarakan/{controller=Index}/{action=Dashboard}/{id?}");

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
