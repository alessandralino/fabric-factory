using tshirt_factory.src.Models;

namespace tshirt_factory.src.Services
{
    public interface ITShirtService
    {
        CustomTShirt CreateTShirt(string name, string variationType, string customData);

        CustomTShirt GetTShirt(int id);

        IEnumerable<CustomTShirt> GetAllTShirts();

        void UpdateTShirt(int id, string name, string variationType, string customData);

        void DeleteTShirt(int id);
    }
}
