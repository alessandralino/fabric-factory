using tshirt_factory.src.Models;
using tshirt_factory.src.Repositories;
using tshirt_factory.src.Strategies;
using System.Collections.Generic;
using System.Security.Cryptography.Xml;

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

        public CustomTShirt GetTShirt(int id)
        {
            var tShirt = _repository.GetById(id);
            if (tShirt == null)
            {
                throw new KeyNotFoundException($"T-Shirt with ID {id} not found.");
            }
            return tShirt;
        }

        public IEnumerable<CustomTShirt> GetAllTShirts()
        {
            return _repository.GetAll();
        }

        public void UpdateTShirt(int id, string name, string variationType, string customData)
        {
            var tShirt = _repository.GetById(id);
            if (tShirt == null)
            {
                throw new KeyNotFoundException($"T-Shirt with ID {id} not found.");
            }

            var strategy = CustomizationStrategyFactory.GetStrategy(variationType);

            tShirt.Name = name;
            tShirt.VariationType = variationType;
            tShirt.CustomData = strategy.ApplyCustomization(customData);

            _repository.Update(tShirt);
        }

        public void DeleteTShirt(int id)
        {
            var tShirt = _repository.GetById(id);
            
            if (tShirt == null)
            {
                throw new KeyNotFoundException($"T-Shirt with ID {id} not found.");
            }

            
            _repository.Delete(tShirt.Id);
        }
    }
}
