namespace tshirt_factory.src.Strategies
{
    public class TextCustomization : ICustomizationStrategy
    {
        public string ApplyCustomization(string inputData)
        {
            return $"Customized with text: {inputData}";
        }
    }
}
