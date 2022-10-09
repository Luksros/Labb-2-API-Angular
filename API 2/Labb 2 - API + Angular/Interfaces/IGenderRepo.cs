namespace Labb_2___API___Angular.Models.Interfaces
{
    public interface IGenderRepo
    {
        public IEnumerable<Gender> GetAll();
        public Gender GetById(int id);
    }
}
