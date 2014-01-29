using Abp.Domain.Policies;
using Abp.Security.Users;
using Abp.Users;

namespace Taskever.Friendships
{
    public interface IFriendshipPolicy : IPolicy
    {
        bool CanChangeFriendshipProperties(AbpUser currentUser, Friendship friendShip);
        bool CanRemoveFriendship(AbpUser currentUser, Friendship friendship);
    }
}