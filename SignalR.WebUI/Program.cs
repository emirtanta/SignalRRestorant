using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Authorization;
using SignalR.DataAccessLayer.Concrete;
using SignalR.EntityLayer.Entities;
using System.Net;

var builder = WebApplication.CreateBuilder(args);

//proje seviyesin authorize iþlemi
var requireAuthorizePolicy = new AuthorizationPolicyBuilder()
	.RequireAuthenticatedUser()
	.Build();

// Add services to the container.

/* alttaki kod proje bazlý yetkilendirme iþlemi için opsiyonel olarak tanýmlandý
 opt=>
    {
        opt.Filters.Add(new AuthorizeFilter(requireAuthorizePolicy));
    });
 */
builder.Services.AddControllersWithViews(opt =>
	{
		opt.Filters.Add(new AuthorizeFilter(requireAuthorizePolicy));
	});

//yetkisiz sayfalara gidildiðinde login sayfasýna yönlendirme iþlemi
builder.Services
	.ConfigureApplicationCookie(opts =>
	{
		opts.LoginPath = "/Login/Index";
	});



builder.Services.AddDbContext<SignalRContext>();
builder.Services.AddIdentity<AppUser, AppRole>()
	.AddEntityFrameworkStores<SignalRContext>();

//api'yi dýþa açtýk
builder.Services.AddHttpClient();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
	app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();

app.UseAuthorization();

app.MapControllerRoute(
	name: "default",
	pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
