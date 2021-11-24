using meetup_1_asp_net_core.Models;
using System.Collections.Generic;

namespace meetup_1_asp_net_core.Interfaces
{
    public interface ICommentsService
    {
        List<Comment> GetAllComments();

        void CreateComment(string message);
    }
}
