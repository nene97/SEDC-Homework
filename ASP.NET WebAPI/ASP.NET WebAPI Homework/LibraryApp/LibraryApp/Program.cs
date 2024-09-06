using LibraryApp.DataAccess;
using LibraryApp.Helpers;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


builder.Services.AddControllers().AddJsonOptions(x =>
                x.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);


DependencyInjectionHelper.InjectRepository(builder.Services);
DependencyInjectionHelper.InjectServices(builder.Services);



var appSettings = builder.Configuration.GetSection("DbSettings");

builder.Services.Configure<DataBaseSettings>(appSettings);
DataBaseSettings dbSettings = appSettings.Get<DataBaseSettings>();
var connectionString = dbSettings.ConnectionString;

DependencyInjectionHelper.InjectDbContext(builder.Services, connectionString);








var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
