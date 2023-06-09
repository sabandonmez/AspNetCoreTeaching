using FluentValidation.AspNetCore;
using Microsoft.Extensions.DependencyInjection.Extensions;
using OrnekProje.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

builder.Services.AddSingleton<ConsoleLog>();
builder.Services.AddScoped<TextLog>();
builder.Services.AddTransient<PerformanceLog>(p=> new PerformanceLog(12));

builder.Services.AddControllersWithViews().AddFluentValidation(x=> x.RegisterValidatorsFromAssemblyContaining<Program>());

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute("OrnekCustomRoute", "{controller=Home}/{action=Index}/{a}/{b}/{id}");
    endpoints.MapDefaultControllerRoute();
});

app.MapRazorPages();

app.Run();
