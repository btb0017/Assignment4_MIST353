using EcoInvestAPI.Data;
using EcoInvestAPI.Entities;
using EcoInvestAPI.Repositories;
using EcoInvestAPI.Repositories.NewRepo;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddScoped<ISearchCompaniesByGeo, SearchCompaniesByGeoContoller>();
builder.Services.AddScoped<IAddClimateAndStockData, AddClimateAndStockDataController>();
builder.Services.AddScoped<ICompanyService, CompanyService>();
builder.Services.AddScoped<ICompanyRatingService, CompanyRatingService>();
builder.Services.AddScoped<IViewCompanyDataByDateRangeService, ViewCompanyDataByDateRangeService>();
builder.Services.AddScoped<IStockDataByDateRangeService, StockDataByDateRangeService>();
builder.Services.AddDbContext<DbContextClass>(options => 
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowMyFrontEnd", policy =>
        policy.AllowAnyOrigin()
              .AllowAnyHeader()
              .AllowAnyMethod());
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseCors("AllowMyFrontEnd");

app.UseAuthorization();

app.MapControllers();

app.Run();
