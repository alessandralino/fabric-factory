namespace tshirt_factory.src.Strategies
{
    public class CustomizationStrategyFactory
    {
        public static ICustomizationStrategy GetStrategy(string variationType)
        {
            return variationType.ToLower() switch
            {
                "text" => new TextCustomization(),
                "image" => new ImageCustomization(),
                _ => throw new NotSupportedException("Variation type not supported")
            };
        }
    }
}
