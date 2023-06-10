using Microsoft.AspNetCore.Authentication;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.OpenApi.Models;
using System;
using VeterinarskaStanica.Filters;
using VeterinarskaStanica.Model.SearchObjects;
using VeterinarskaStanica.Services;
using VeterinarskaStanica.Services.Database;
using VeterinarskaStanica.Services.ProductStateMachine;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers(x =>
{
	x.Filters.Add<ErrorFilter>(); 
});
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
	c.AddSecurityDefinition("basicAuth", new Microsoft.OpenApi.Models.OpenApiSecurityScheme
	{
		Type = Microsoft.OpenApi.Models.SecuritySchemeType.Http,
		Scheme = "basic"
	});
	c.AddSecurityRequirement(new OpenApiSecurityRequirement
	{
		{
			new OpenApiSecurityScheme
			{
				Reference = new OpenApiReference { Type = ReferenceType.SecurityScheme, Id = "basicAuth" }
			},
			new string[]{}
		}
	});
});

builder.Services.AddTransient<IProizvodiService, ProizvodiService>();
builder.Services.AddTransient<IUslugeService, UslugeService>();
builder.Services.AddTransient<IKorisniciService, KorisniciService>();
builder.Services.AddTransient<IJediniceMjereService, JediniceMjereService>();
builder.Services.AddTransient<IVrsteProizvodaService, VrsteProizvodaService>();
builder.Services.AddTransient<IVrsteUslugaService, VrstaUslugaService>();
builder.Services.AddTransient<INarudzbeService, NarudzbeService>();
builder.Services.AddTransient<IService<VeterinarskaStanica.Model.Uloge, BaseSearchObject>, BaseService<VeterinarskaStanica.Model.Uloge, Uloge, BaseSearchObject >>();
//builder.Services.AddSingleton<IProizvodiService, ProizvodiService>();
builder.Services.AddTransient<BaseState>();
builder.Services.AddTransient<InitialProductState>();
builder.Services.AddTransient<DraftProductState>();
builder.Services.AddTransient<ActiveProductState>();
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<VeterinarskaStanicaContext>(options => options.UseSqlServer(connectionString));
builder.Services.AddAutoMapper(typeof(IKorisniciService));
builder.Services.AddAuthentication("BasicAuthentication")
	.AddScheme<AuthenticationSchemeOptions, BasicAuthenticationHandler>("BasicAuthentication", null);

var app = builder.Build();

using (var Scope = app.Services.CreateScope())
{
	var context = Scope.ServiceProvider.GetRequiredService<VeterinarskaStanicaContext>();
	//context.Database.Migrate();
}

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
	app.UseSwagger();
	app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthentication();

app.UseAuthorization();

app.MapControllers();

app.Run();
