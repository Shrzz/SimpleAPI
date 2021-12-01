using Simple_API.Models;

namespace Simple_API.Services
{
    public interface IFilmService
    {
        public Film Create(Film film);
        public Film? Get(int id);
        public Film? Update(Film film);
        public List<Film> GetAll();
        public bool Delete(int id);            
    }
}
