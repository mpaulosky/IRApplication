
using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Reflection;

using AutoMapper;

using IR.Shared.Data;
using IR.Shared.Interfaces;
using IR.Shared.Mapping;
using IR.Shared.Repositories;
using IR.Shared.Services;

using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;

namespace IR.Server
{
	[ExcludeFromCodeCoverage]
	public class Startup
	{
		public Startup(IConfiguration configuration)
		{
			Configuration = configuration;
		}

		public IConfiguration Configuration { get; }

		// This method gets called by the runtime. Use this method to add services to the container.
		public void ConfigureServices(IServiceCollection services)
		{
			services.AddDbContext<DataContext>(
				o => o.UseSqlServer(
					Configuration.GetConnectionString("IRDataConnection")));

			services.AddControllers().AddNewtonsoftJson();

			services.AddSwaggerGen(c =>
			{
				c.SwaggerDoc("v1", new OpenApiInfo
				{
					Title = "IR.Server",
					Description = "A sample ASP .NET Core Web API that allows you to work with Issue data.",
					Contact = new OpenApiContact
					{
						Name = "Matthew Paulosky",
						Email = "mpaulosky@paulosky.org",
						Url = new Uri("https://github.com/mpaulosky/IRApplication")
					},
					License = new OpenApiLicense
					{
						Name = "MIT License",
						Url = new Uri("https://opensource.org/licenses/MIT")
					},
					Version = "v1"
				});
				// Generate the xml docs that will drive the swagger docs
				var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
				var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
				c.IncludeXmlComments(xmlPath);
			}).AddSwaggerGenNewtonsoftSupport();

			// Auto Mapper Configurations
			var mappingConfig = new MapperConfiguration(mc => { mc.AddProfile(new MappingProfile()); });

			var mapper = mappingConfig.CreateMapper();

			services.AddSingleton(mapper);

			services.AddScoped<IRepository, Repository<DataContext>>();
			services.AddScoped<IIssueService, IssueService>();
		}

		// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
		public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
		{
			if (env.IsDevelopment())
			{
				app.UseDeveloperExceptionPage();
				app.UseSwagger();
				app.UseSwaggerUI(c => 
				{
					c.DisplayOperationId(); // To show the name of the methods on the right side of the UI
					c.SwaggerEndpoint("/swagger/v1/swagger.json", "IR.Server v1");
					});
			}

			app.UseHttpsRedirection();

			app.UseRouting();

			app.UseAuthorization();

			app.UseEndpoints(endpoints =>
			{
				endpoints.MapControllers();
			});
		}
	}
}