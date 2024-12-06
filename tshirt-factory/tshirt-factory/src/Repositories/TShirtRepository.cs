using tshirt_factory.src.Context;
using tshirt_factory.src.Models;

namespace tshirt_factory.src.Repositories
{
    public class TShirtRepository : ITShirtRepository
    {
        private readonly TShirtContext _context;

        public TShirtRepository(TShirtContext context)
        {
            _context = context;
        }

        public void Create(CustomTShirt tShirt)
        {
            _context.CustomTShirts.Add(tShirt);
            _context.SaveChanges();
        }

        public CustomTShirt Read(int id)
        {
            return _context.CustomTShirts.Find(id);
        }

        public IEnumerable<CustomTShirt> List()
        {
            return _context.CustomTShirts.ToList();
        }

        public void Update(CustomTShirt tShirt)
        {
            _context.CustomTShirts.Update(tShirt);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var tShirt = _context.CustomTShirts.Find(id);
            if (tShirt != null)
            {
                _context.CustomTShirts.Remove(tShirt);
                _context.SaveChanges();
            }
        }

        public IEnumerable<CustomTShirt> GetAll()
        {
            return _context.CustomTShirts.ToList();
        }

        public CustomTShirt GetById(int id)
        {
            var tShirt = _context.CustomTShirts.Find(id);

            if (tShirt == null)
            {
                throw new KeyNotFoundException($"T-Shirt with ID {id} not found.");
            }

            return tShirt;
        }
    }
}
