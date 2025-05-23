using Cours_Get_Post_Formulaires.Controllers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            RequetesController rc = new RequetesController();

            var httpContext = new DefaultHttpContext();
            httpContext.Request.QueryString = new QueryString("?prenom=Dupont");

            rc.ControllerContext = new ControllerContext()
            {
                HttpContext = httpContext
            };

            var r = rc.ReceptionRequeteGet("allo");
            Assert.NotNull(r);
            //TODO : à compléter
        }
    }
}
