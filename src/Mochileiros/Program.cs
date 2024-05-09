using Microsoft.EntityFrameworkCore;
using Mochileiros.Data;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<MochileirosContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("MochileirosContext") ?? throw new InvalidOperationException("Connection string 'MochileirosContext' not found.")));

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddRouting(options => options.LowercaseUrls = true);
builder.Services.AddControllersWithViews();

if (builder.Environment.IsDevelopment())
{
    builder.Services.AddDbContext<MochileirosContext>(options =>
        options.UseSqlite(builder.Configuration.GetConnectionString("MochileirosContext")));
}
else
{
    builder.Services.AddDbContext<MochileirosContext>(options =>
        options.UseSqlServer(builder.Configuration.GetConnectionString("MochileirosContext")));
}



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
