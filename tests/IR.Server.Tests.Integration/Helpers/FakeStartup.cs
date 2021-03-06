using IR.Shared.Data;
using IR.Shared.Interfaces;
using IR.Shared.Models;
using IR.Shared.Repositories;
using IR.Shared.Services;

using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Identity.Web;

using System;
using System.Linq;

namespace IR.Server.Tests.Integration.Helpers
{
	public class FakeStartup //: Startup
	{
		public FakeStartup(IConfiguration configuration)
		{
			Configuration = configuration;
		}

		public IConfiguration Configuration { get; }

		public virtual void ConfigureServices(IServiceCollection services)
		{
			var descriptor = services.SingleOrDefault(
		d => d.ServiceType == typeof(DbContextOptions<DataContext>));
			services.Remove(descriptor);

			services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
				.AddMicrosoftIdentityWebApi(Configuration.GetSection("AzureAd"));

			services.Configure<JwtBearerOptions>(
				JwtBearerDefaults.AuthenticationScheme,
				options => { options.TokenValidationParameters.NameClaimType = "name"; });

			services.AddDbContext<DataContext>(
				o => o.UseSqlServer(
					Configuration.GetConnectionString("TestConnection")));


			services.AddScoped<IRepository, Repository<DataContext>>();
			services.AddScoped<IIssueService, IssueService>();
			services.AddScoped<ICommentService, CommentService>();
			services.AddScoped<IResponseService, ResponseService>();
		}

		public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
		{
			app.UseHttpsRedirection();

			app.UseStaticFiles();

			app.UseRouting();

			app.UseAuthentication();

			app.UseAuthorization();

			app.UseEndpoints(endpoints =>
			{
				endpoints.MapRazorPages();
				endpoints.MapControllers();
				endpoints.MapFallbackToFile("index.html");
			});

			var serviceScopeFactory = app.ApplicationServices.GetRequiredService<IServiceScopeFactory>();

			using (var serviceScope = serviceScopeFactory.CreateScope())
			{
				var dbContext = serviceScope.ServiceProvider.GetService<DataContext>();
				if (dbContext == null)
				{
					throw new NullReferenceException("Cannot get instance of dbContext");
				}

				if (dbContext.Database.GetDbConnection().ConnectionString.ToLower().Contains("TestConnection"))
				{
					throw new Exception("LIVE SETTINGS IN TESTS!");
				}

				dbContext.Database.EnsureDeleted();
				dbContext.Database.EnsureCreated();

				dbContext.Issues.Add(new Issue { Id = 1, IssueDescription = "Customer 1", InitiatorId = new Guid().ToString(), InitiatorName = "test.tester@tester.com", IsDeleted = false, IsResolved = false });
				dbContext.Issues.Add(new Issue { Id = 2, IssueDescription = "Customer 2", InitiatorId = new Guid().ToString(), InitiatorName = "test.tester@tester.com", IsDeleted = false, IsResolved = false });
				dbContext.SaveChanges();
			}
		}
	}
}
