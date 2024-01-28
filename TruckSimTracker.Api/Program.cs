using TruckSimTracker.Services;
using TruckSimTracker.Data;
using TruckSimTracker.Data.Repositories;
using TruckSimTracker.Server;


string CustomCorsPolicy = "_customCorsPolicy";

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddCors(options =>
{
    options.AddPolicy(name: CustomCorsPolicy,
        policy =>
        {
            policy.WithOrigins(
                "https://localhost:3000", 
                "http://localhost:3000"
            );
        });
});

// register databases
string dbPath = FileAccessHelper.GetLocalFilePath("truck-sim-tracker.db3");
builder.Services.AddSingleton<ITruckSimTrackerRepository>(s => ActivatorUtilities.CreateInstance<TruckSimTrackerRepository>(s, dbPath));


// register our services
builder.Services.AddSingleton<IDlcContentService, DlcContentService>();
builder.Services.AddSingleton<IJobService, JobService>();
builder.Services.AddSingleton<IStateService, StateService>();
builder.Services.AddSingleton<IAchievementService, AchievementService>();
builder.Services.AddSingleton<ICityService, CityService>();
builder.Services.AddSingleton<IDepotService, DepotService>();
builder.Services.AddSingleton<ICargoTypeService, CargoTypeService>();
builder.Services.AddSingleton<ICargoService, CargoService>();

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

//app.UseAuthorization();

app.MapControllers();

app.UseCors(CustomCorsPolicy);

app.MapFallbackToFile("/index.html");

app.Run();

WebApplication RegisterServices(WebApplication app)
{
    return app;
}

