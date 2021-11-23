using Microsoft.AspNetCore.Mvc;

namespace meetup_1_asp_net_core.Controllers
{
    public class CommentsController : Controller
    {
        public string Index()
        {
            return "This is my default action...";
        }

        public string Welcome()
        {
            return "This is the Welcome action method...";
        }
    }
}