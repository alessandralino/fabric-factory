using tshirt_factory.src.Models;

namespace tshirt_factory.src.Repositories
{
    public interface ITShirtRepository
    {
        void Create(CustomTShirt tShirt);

        CustomTShirt Read(int id);

        IEnumerable<CustomTShirt> List();

        void Update(CustomTShirt tShirt);

        void Delete(int id);
    }
}
