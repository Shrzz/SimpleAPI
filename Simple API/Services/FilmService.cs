using Simple_API.Models;
using Simple_API.Repositories;

namespace Simple_API.Services
{
    public class FilmService : IFilmService
    {
        public Film Create(Film film)
        {
            film.Id = FilmRepository.Films.Count;
            FilmRepository.Films.Add(film);

            return film;
        }

        public bool Delete(int id)
        {
            var f = FilmRepository.Films.FirstOrDefault(f => f.Id == id);

            if (f is null) return false;

            FilmRepository.Films.Remove(f);

            return true;
        }

        public Film? Get(int id)
        {
            var film = FilmRepository.Films.FirstOrDefault(fil => fil.Id == id);

            if (film is null) return null;

            return film;
        }

        public List<Film> GetAll()
        {
            var filmList = FilmRepository.Films;

            return filmList;
        }

        public Film? Update(Film film)
        {
            var oldFilm = FilmRepository.Films.FirstOrDefault(f => f.Id == film.Id);

            if (oldFilm is null) return null;

            oldFilm.Title = film.Title;
            oldFilm.Description = film.Description;

            return film;
        }
    }
}
