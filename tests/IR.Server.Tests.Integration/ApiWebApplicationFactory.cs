using IR.Shared.Data;
using IR.Shared.Interfaces;
using IR.Shared.Repositories;
using IR.Shared.Services;

using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.AspNetCore.TestHost;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

using IConfiguration = Microsoft.Extensions.Configuration.IConfiguration;

namespace IR.Server.Tests.Integration
{
	public class ApiWebApplicationFactory : WebApplicationFactory<Startup>
	{
		public IConfiguration Configuration { get; private set; }

		protected override void ConfigureWebHost(IWebHostBuilder builder)
		{
			builder.ConfigureAppConfiguration(config => 
			{ 
				Configuration = new ConfigurationBuilder()
				.AddJsonFile("integrationsettings.json")
				.Build(); 
				
				config.AddConfiguration(Configuration);
			});

			builder.ConfigureTestServices(services =>
			{
				services.AddScoped<IRepository, Repository<DataContext>>();
				services.AddScoped<IIssueService, IssueService>();
				services.AddScoped<ICommentService, CommentService>();
				services.AddScoped<IResponseService, ResponseService>();
			});
		}
	}
}
