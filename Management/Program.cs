using ManagementDataService;
using ManagementDataService.Repositiory;
using ManagementService;
using ManagementUtility;
using Microsoft.OpenApi;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

//builder.Services.AddSingleton<IDbContext>(
//    new DBContext(builder.Configuration.GetConnectionString("TrackingConnection")));

//builder.Services.AddScoped<ICustomerRepository, CustomerRepository>();
//builder.Services.AddScoped<ICustomerService, CustomerService>();
//// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle    
//builder.Services.AddEndpointsApiExplorer();
//builder.Services.AddSwaggerGen(c =>
//{
//    c.SwaggerDoc("v1", new OpenApiInfo
//    {
//        Title = "My API",
//        Version = "v1",
//        Description = "ASP.NET Core 8 Web API with Swagger"
//    });
//});
var app = builder.Build();

// Configure the HTTP request pipeline.
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Customer}/{action=GetCustomer}/{id?}");

app.UseHttpsRedirection();

app.UseAuthorization();



app.Run();
