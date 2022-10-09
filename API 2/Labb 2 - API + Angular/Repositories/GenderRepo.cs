using Labb_2___API___Angular.Models;
using Labb_2___API___Angular.Models.Interfaces;

namespace Labb_2___API___Angular.Repositories
{
    public class GenderRepo : IGenderRepo
    {
        private readonly AppDbContext _context;

        public GenderRepo(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Gender> GetAll()
        {
            return _context.Genders.ToList();
        }

        public Gender GetById(int id)
        {
            return _context.Genders.FirstOrDefault(g => g.ID == id);
        }
    }
}
