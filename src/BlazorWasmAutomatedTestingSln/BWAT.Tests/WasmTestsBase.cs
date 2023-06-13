using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BWAT.Tests
{
    public class WasmTestsBase
    {
        protected readonly TestServer _server;
        protected readonly HttpClient _client;
        public WasmTestsBase() {
            // Create a TestServer instance without using Startup.cs
            _server = new TestServer(new WebHostBuilder()
                               .UseStartup<Startup>());

            // Create a HttpClient instance
            _client = _server.CreateClient();
        }
    }
}
