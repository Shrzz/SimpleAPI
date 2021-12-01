using Simple_API.Models;

namespace Simple_API.Repositories
{
    public class FilmRepository
    {
        public static List<Film> Films = new List<Film>
        {
            new(){Id = 0, Title = "The Notebook", Description = "The Notebook, based on Nicholas Sparks's 1996 novel, is a must-watch for all of the hopeless romantics out there who believe they'll eventually find their way back to their one true love."},
            new(){Id = 1, Title = "Parasite", Description = "An unemployed family of four slips into the lives of the crazy wealthy Park family. Then, there's an incident that can’t entirely be cleaned up in a cleaning shift. Long after the credits roll, you’ll be questioning the ending and mulling over the tough, important themes."},
            new(){Id = 2, Title = "Titanic", Description = "If you haven't watched Titanic yet (please don't admit this out loud), do yourself a favor and stream it on Hulu immediately."},
            new(){Id = 3, Title = "Casablanca", Description = "Set in the early years of World War II in Casablanca, Rick Blaine's (Humphrey Bogart) nightclub is an oasis for refugees despite the warnings he gets from local authorities. But things get rocky when an ex-lover and her boyfriend show up, bringing with them a challenge that Rick has to face. One of the most famous old Hollywood films of all time, Casablanca is a love story you won't forget." }
        };
    }
}
