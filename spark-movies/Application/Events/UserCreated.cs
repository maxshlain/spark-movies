using spark_movies.Application.Models;
using Coravel.Events.Interfaces;

namespace spark_movies.Application.Events
{

    public class UserCreated : IEvent
    {
        public User User { get; set; }

        public UserCreated(User user)
        {
            this.User = user;
        }
    }
}
