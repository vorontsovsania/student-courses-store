using System.IO;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using CoursesStore.Service;
using CoursesStore.Service.Contract.Paging;
using CoursesStore.Service.Contract.Students;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using Microsoft.Extensions.Configuration;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;

namespace CourseStore.Service.IntegrationTests
{
    [TestClass]
    [TestCategory("Service_Integration")]
    public class StudentsControllerIntegrationTests
    {
        //todo use IClassFixture to share context
        private TestServer _testServer;
        private HttpClient _httpClient;

        [TestInitialize]
        public void Initialize()
        {
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            _testServer = new TestServer(new WebHostBuilder()
                .UseStartup<Startup>()
                .UseConfiguration(configuration));

            _httpClient = _testServer.CreateClient();
            _httpClient.DefaultRequestHeaders.Accept.Clear();
            _httpClient.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
        }

        [TestCleanup]
        public void Cleanup()
        {
            _testServer.Dispose();
            _httpClient.Dispose();
        }

        [TestMethod]
        public async Task StudentListShouldBeReturnedTest()
        {
            string studentsListUrl = "/students";
            var requestFilter = CreateFilter();
            var response = await _httpClient.PutAsync(studentsListUrl,
                new StringContent(JsonConvert.SerializeObject(requestFilter), Encoding.UTF8, "application/json"));

            Assert.AreEqual(response.StatusCode, HttpStatusCode.OK);
            var list = JsonConvert.DeserializeObject<StudentList>(await response.Content.ReadAsStringAsync());
            Assert.AreNotEqual(list.Total, 0);
        }

        private StudentListRequest CreateFilter()
        {
            return new StudentListRequest
            {
                Filter = new StudentListRequestFilter
                {
                    FirstName = "a"
                },
                Pager = new Pager
                {
                    PageNumber = 1,
                    PageSize = 2
                }
            };
        }
    }
}
