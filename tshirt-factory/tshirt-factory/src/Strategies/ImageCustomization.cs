namespace tshirt_factory.src.Strategies
{
    public class ImageCustomization : ICustomizationStrategy
    {
        public string ApplyCustomization(string inputData)
        {
            return $"Customized with image: {inputData}";
        }
    }
}
