namespace ConsoleApp1
{
    public static class Utils
    {
        public static IEnumerable<ProductDto> Map(IEnumerable<Product> sources)
        {
            var result = sources.Select(x => new ProductDto()
            {
                Name = x.Name,
                Description = x.Description
            });
            return result;
        }
    }
}
