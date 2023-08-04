using CRUD_Operation.Command;
using CRUD_Operation.DataBase;
using CRUD_Operation.Handler;
using CRUD_Operation.Repositery.Interface;
using CRUD_Operation.Repositery.Service;
using MediatR;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
//builder.Services.AddMediatR(Assembly.GetExecutingAssembly());
//builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(Assembly.GetExecutingAssembly()));

builder.Services.AddMediatR(typeof(GetEmployeeListHandler));
builder.Services.AddDbContext<DataConnection>();
builder.Services.AddScoped<IEmployeeRepo, EmployeeRepo>();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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