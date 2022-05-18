using Microsoft.AspNetCore.Server.Kestrel.Core;
using Microsoft.AspNetCore.Server.Kestrel.Https;
using Microsoft.EntityFrameworkCore;
using server.Models;

var builder = WebApplication.CreateBuilder(args);

// builder.Services.Configure<KestrelServerOptions>(options =>
// {
//     options.ConfigureHttpsDefaults(options =>
//         options.ClientCertificateMode = ClientCertificateMode.RequireCertificate);
// });


// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddDbContext<NumNumsContext>();


// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
//builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.

//original code 
//if (app.Environment.IsDevelopment())
//{
//    app.UseDeveloperExceptionPage();
//    //app.UseSwagger();
//    //app.UseSwaggerUI();
//}






//changed app.env to builder.env
if (builder.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
    //app.UseSwagger();
    //app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

