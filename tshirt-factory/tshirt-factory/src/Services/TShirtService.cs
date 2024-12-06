using tshirt_factory.src.Models;
using tshirt_factory.src.Repositories;
using tshirt_factory.src.Strategies;

namespace tshirt_factory.src.Services
{
    public class TShirtService : ITShirtService
    {
        private readonly ITShirtRepository _repository;

        public TShirtService(ITShirtRepository repository)
        {
            _repository = repository;
        }

        public CustomTShirt CreateTShirt(string name, string variationType, string customData)
        {
            var strategy = CustomizationStrategyFactory.GetStrategy(variationType);
            
            var customizedData = strategy.ApplyCustomization(customData);

            var tShirt = new CustomTShirt
            {
                Name = name,
                VariationType = variationType,
                CustomData = customizedData
            };

            _repository.Create(tShirt);

            return tShirt;
        }

        public void DeleteTShirt(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<CustomTShirt> GetAllTShirts()
        {
            throw new NotImplementedException();
        }

        public CustomTShirt GetTShirt(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateTShirt(int id, string name, string variationType, string customData)
        {
            throw new NotImplementedException();
        }
    }
}
