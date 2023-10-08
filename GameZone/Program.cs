var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();


#region ConnectionString

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection") 
                              ?? throw new InvalidOperationException("No Connection String was found");

builder.Services.AddDbContext<ApplicationDbContext>(option =>
{
    option.UseSqlServer(connectionString);
});

#endregion

#region AddIdentity

builder.Services.AddIdentity<ApplicationUser, IdentityRole>(option =>
{
    option.Password.RequireNonAlphanumeric = false;
    option.Password.RequireUppercase = false;
    option.Password.RequireLowercase = false;
}).AddEntityFrameworkStores<ApplicationDbContext>();

#endregion

#region Register Services

builder.Services.AddScoped<ICategoriesService,CategoriesService>();
builder.Services.AddScoped<IDevicesService,DevicesService>();
builder.Services.AddScoped<IGamesService,GamesService>();

#endregion

#region AddSession
builder.Services.AddSession(option =>
{
    option.IdleTimeout = TimeSpan.FromMinutes(30);
});
#endregion

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
app.UseSession();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();

