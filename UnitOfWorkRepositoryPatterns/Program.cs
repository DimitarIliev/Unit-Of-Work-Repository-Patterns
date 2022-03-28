using Library.Domain.UnitOfWork;
using Library.Infrastructure;
using Library.Infrastructure.UnitOfWork;
using Microsoft.EntityFrameworkCore;
using UnitOfWorkRepositoryPatterns.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddTransient(typeof(IBookService), typeof(BookService));

//Database
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
builder.Services.AddDbContext<LibraryDbContext>(
               x => x.UseSqlServer(builder.Configuration.GetConnectionString("LibraryConnection")));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
