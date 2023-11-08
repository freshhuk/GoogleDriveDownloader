var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
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

app.MapControllerRoute(
    name: "default",
    pattern: "api/{controller=DownloaderOnGoogleDriveController}/{action=DriveUploadBasic}/{id?}");

app.MapControllerRoute(
    name: "filedowloader",
    pattern: "filedowloader/{*article}",
    defaults: new { controller = "FileDownloader", action = "DowloadFile" });

app.Run();
