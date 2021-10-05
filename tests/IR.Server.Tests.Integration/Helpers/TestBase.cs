using Microsoft.AspNetCore.Mvc.Testing;
using Xunit;

namespace IR.Server.Tests.Integration.Helpers
{
	public abstract class TestBase : IClassFixture<TestApplicationFactory<Startup, FakeStartup>>
	{
		protected WebApplicationFactory<FakeStartup> Factory { get; }

		public TestBase(TestApplicationFactory<Startup, FakeStartup> factory)
		{
			Factory = factory;
		}

		// Add you other helper methods here
	}
}
