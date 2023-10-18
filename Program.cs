using Microsoft.EntityFrameworkCore;
using Sistema_de_Cadastro_de_Fornecedor.Context;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

string connectionString = "Server=DESKTOP-P41C4DQ\\SQLEXPRESS;DataBase=FornecedoresDb; Trusted_Connection=True; TrustServerCertificate=True; MultipleActiveResultSets=true;";

builder.Services.AddDbContext<FornecedoresDdContext>(o => o.UseSqlServer(connectionString));



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

app.Run();
