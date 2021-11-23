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

        string Custom()
        {
            return "This won't be displayed";
        }
    }
}