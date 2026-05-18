namespace Task_3_4
{
    public class NetworkImageStrategy : IImageLoadStrategy
    {
        public string Load(string href)
        {
            return $"Loading image from network: {href}";
        }
    }
}
