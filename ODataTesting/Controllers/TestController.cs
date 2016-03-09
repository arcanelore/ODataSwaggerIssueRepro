using ODataTesting.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Http.Description;
using System.Web.OData;
using System.Web.OData.Routing;

namespace ODataTesting.Controllers
{
    /// <summary>
    /// Test Controller
    /// </summary>
    public class TestController :ODataController
    {
        /// <summary>
        /// Returns a List of Test Models
        /// </summary>
        /// <returns>List of TestModels</returns>
        /// <remarks>The Get Method will return a list of All TestModels</remarks>
        /// <response code="200">Ok- Test Models Found</response>
        /// <response code="400">Bad Request</response>
        /// <response code="401">Unauthorize, Token is expired</response>
        /// <response code="404">Not Found- No Test Models Found</response>
        /// <response code="500">Internal Server Error</response>
        [ODataRoute("TestModel")]
        [HttpGet, ResponseType(typeof(List<TestModel>)), EnableQuery]
        public IHttpActionResult Get(string TestId)
        {
            List<TestModel> testModels = new List<TestModel>();

            TestModel testModel = new TestModel()
            {
                TestModelId = "TestId1",
                TestBool = true,
                TestDateTime = DateTime.Now,
                TestDouble = 4936.56,
                TestInt = 1024,
                TestString = "TestString1"
            };

            testModels.Add(testModel);

            testModel = new TestModel()
            {
                TestModelId = "TestId2",
                TestBool = true,
                TestDateTime = DateTime.UtcNow,
                TestDouble = 9873.12,
                TestInt = 2048,
                TestString = "TestString2"
            };

            testModels.Add(testModel);

            return Ok(testModels);
        }
    }
}