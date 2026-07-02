using AutoGenerator;
using LAHJA.API.Data;
using Saad.API;
using SADA.API.Models;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddSingleton<UserClaimsHelper>();
 

builder.Services.AddScoped<IClientFactory, HttpClientFactory>();
builder.Services.AddHttpContextAccessor();
builder.Services
       .AddWasmAutoGeneratorApi<LahjaDataContext, ApplicationUser>(new()
       {
           Arags = args,
           NameRootApi = "V1",

           Assembly = Assembly.GetExecutingAssembly(),
           DbConnectionString = builder.Configuration.GetConnectionString("DefaultConnection"),//UseSqlServer يمكن انشاء قاعده بيانات  

       });
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowReactApp", policy =>
    {
        policy.WithOrigins(
                "https://vivo2.lahjai.net"
            )
            .AllowAnyHeader()
            .AllowAnyMethod();
    });
});
var app = builder.Build();

//// Configure the HTTP request pipeline.
//if (app.Environment.IsDevelopment())
//{
//    app.UseSwagger();
//    app.UseSwaggerUI();
//}

app.UseHttpsRedirection();
// ✅  Middleware Registration
app.UseWasmAutoGeneratorApi();
app.UseCors("AllowReactApp");
app.UseAuthorization();

app.MapControllers();

app.Run();
