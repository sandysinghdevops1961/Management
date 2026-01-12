using ManagementDataService;
using ManagementDataService.Repositiory;
using ManagementService;
using ManagementUtility;
using Microsoft.OpenApi;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container
builder.Services.AddControllers();

// DB & DI (uncomment when ready)
builder.Services.AddSingleton<IDbContext>(
     new DBContext(builder.Configuration.GetConnectionString("TrackingConnection")));
builder.Services.AddScoped<ICustomerRepository, CustomerRepository>();
builder.Services.AddScoped<ICustomerService, CustomerService>();

// ✅ Swagger services

var app = builder.Build();
app.MapControllers();

// ✅ Swagger middleware

app.UseHttpsRedirection();

app.UseAuthorization();

// ❗ Optional: Conventional routing (keep only if needed)
//app.MapControllerRoute(
//    name: "default",
//    pattern: "{controller=Customer}/{action=GetCustomer}");

app.Run();
