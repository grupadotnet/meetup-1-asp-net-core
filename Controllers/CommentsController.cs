using Microsoft.AspNetCore.Mvc;
using meetup_1_asp_net_core.Interfaces;
using meetup_1_asp_net_core.Models;

namespace meetup_1_asp_net_core.Controllers
{
    public class CommentsController : Controller
    {
        private readonly ICommentsService _commentsService;

        public CommentsController(ICommentsService commentsService)
        {
            _commentsService = commentsService;
        }

        public IActionResult Index()
        {
            var comments = _commentsService.GetAllComments();

            return View(comments);
        }

        public IActionResult Welcome()
        {
            return StatusCode(503);
        }

        public IActionResult Name(string name, int age)
        {
            return Ok(new {
                success = true,
                response = "Ok",
                firstName = name,
                age
            });
        }

        [HttpPost]
        public IActionResult Send([FromForm] NewCommentRequest request)
        {
            _commentsService.CreateComment(request.Message);

            return StatusCode(201, new {
                Created = true,
                Comment = request.Message,
            });
        }
 
        string Custom()
        {
            return "This won't be displayed";
        }
    }
}