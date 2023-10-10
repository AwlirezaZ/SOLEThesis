using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.FileProviders;
using SOFEThesis.Context;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<SofeThesisContext>(options => options.UseSqlServer(
    builder.Configuration.GetConnectionString("ConnStr")
));
var app = builder.Build();

app.UseStaticFiles(new StaticFileOptions()
{
    FileProvider = new PhysicalFileProvider(
                        Path.Combine(Directory.GetCurrentDirectory(), @"Images")),
    RequestPath = new PathString("/app-images")
});
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseCors(corsBuilder => corsBuilder
    .AllowAnyHeader()
    .AllowAnyMethod()
    .SetIsOriginAllowed((host) => true)
    .AllowCredentials());
app.UseAuthorization();

app.MapControllers();

app.Run();
