using Microsoft.AspNetCore.Mvc;

namespace ASP.NET_ROUTAGE.Controllers
{
    public class HelloController : Controller
    {
        public string SayHello()
        {
            return "Hello !";
        }

        
        public string YellHello()
        {
            return "HELLO !";
        }
        [Route("/Say")]
        public string Say()
        {
            return "Hello !";
        }

        [Route("/Yell")]
        public string Yell()
        {
            return "HELLO !";
        }
    }
}