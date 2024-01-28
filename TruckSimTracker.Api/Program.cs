using TruckSimTracker.Services;
using TruckSimTracker.Data;
using TruckSimTracker.Data.Repositories;
using TruckSimTracker.Server;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// register databases
string dbPath = FileAccessHelper.GetLocalFilePath("truck-sim-tracker.db3");
builder.Services.AddSingleton<ITruckSimTrackerRepository>(s => ActivatorUtilities.CreateInstance<TruckSimTrackerRepository>(s, dbPath));


// register our services
builder.Services.AddSingleton<IDownloadableContentService, DownloadableContentService>();
builder.Services.AddSingleton<IJobService, JobService>();

var app = builder.Build();

app.UseDefaultFiles();
app.UseStaticFiles();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.MapFallbackToFile("/index.html");

app.Run();

WebApplication RegisterServices(WebApplication app)
{
    return app;
}

