namespace Task_3_4
{
    public class FileImageStrategy : IImageLoadStrategy
    {
        public string Load(string href)
        {
            return $"Loading image from file: {href}";
        }
    }
}
