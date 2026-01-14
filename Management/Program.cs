using ManagementDataContext;
using ManagementService;
using ManagementUtility;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container
builder.Services.AddControllers();

// DB & DI (uncomment when ready)
builder.Services.AddSingleton<IDbContext>(
     new DBContext(builder.Configuration.GetConnectionString("TrackingConnection")));
builder.Services.AddScoped<IVisitorRepository, VisitorRepository>();
builder.Services.AddScoped<IVisitorService, VisitiorService>();

// ✅ Swagger services

var app = builder.Build();
app.MapControllers();

// ✅ Swagger middleware

app.UseHttpsRedirection();

app.UseAuthorization();



app.Run();
