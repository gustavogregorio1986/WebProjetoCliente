using WebProjetoCliente.Data.Dapper;
using WebProjetoCliente.Data.Repository;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSingleton<DapperContext>();

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddScoped<ClienteReposiotry>();
builder.Services.AddScoped<ProdutoRepository>();

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
