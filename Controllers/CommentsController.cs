using Microsoft.AspNetCore.Mvc;

namespace meetup_1_asp_net_core.Controllers
{
    public class CommentsController : Controller
    {
        public string Index()
        {
            return "Hello World from CommentsController";
        }

        public string Welcome()
        {
            return "Welcome to the .NET Group";
        }

        public string Name(string name, int age)
        {
            // String interpolation
            return $"Hello {name}, you are {age} years old";
        }

        string Custom()
        {
            return "This won't be displayed";
        }
    }
}