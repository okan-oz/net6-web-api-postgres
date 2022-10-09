using Services;
using UserGroupManager.Repository;
using UserGroupManager.Services.UserGroupService;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var services = builder.Services;
var env = builder.Environment;

services.AddDbContext<DataContext>();
services.AddCors();
builder.Services.AddControllers();

services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

services.AddScoped<IUserGroupService, UserGroupService>();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run("http://localhost:4000");

