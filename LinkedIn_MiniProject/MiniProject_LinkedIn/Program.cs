using Microsoft.EntityFrameworkCore;
using MiniProject_LinkedIn.Code.Interfaces;
using MiniProject_LinkedIn.Code.SqlServer;
using MiniProject_LinkedIn.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<UserContext>(options =>
{
    options.UseSqlServer("Server=PC0404\\MSSQL2019;Database=LinkedInDB;Trusted_Connection=True;TrustServerCertificate=True;MultipleActiveResultSets=true");
});
builder.Services.AddTransient<IUserInfoRepository, UserInformationRepository>();
builder.Services.AddTransient<IConnectionRepo, UserConnectionRepository>();
builder.Services.AddCors(options =>
{
    options.AddPolicy(name: "Policy1",
                      policy =>
                      {
                          policy.WithOrigins("http://localhost:4200").AllowAnyHeader().AllowAnyMethod();
                      });
});
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseCors();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
