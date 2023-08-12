using CapstoneProjectRegister_DamAnhBang_WebRazorPage.Repo.IRepository;
using CapstoneProjectRegister_DamAnhBang_WebRazorPage.Repo.Repository;
using CapstoneProjectRegister_DamAnhBang_WebRazorPage.Service.Service;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

// Đăng ký dịch vụ IStudent và StudentRepository
builder.Services.AddScoped<IStudent, StudentRepository>();

// Đăng ký dịch vụ StudentService
builder.Services.AddScoped<StudentService>();

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

app.MapRazorPages();

app.Run();
