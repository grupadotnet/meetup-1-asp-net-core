using meetup_1_asp_net_core.Models;

namespace meetup_1_asp_net_core.Interfaces
{
    public interface ICommentsService
    {
        Comment[] GetAllComments();

        void CreateComment(string message);
    }
}
