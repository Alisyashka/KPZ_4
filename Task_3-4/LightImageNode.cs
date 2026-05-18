namespace Task_3_4
{
    public class LightImageNode : LightNode
    {
        private string href;
        private IImageLoadStrategy strategy;

        public LightImageNode(string href)
        {
            this.href = href;
            SetStrategy();
        }

        private void SetStrategy()
        {
            if (href.StartsWith("http"))
            {
                strategy = new NetworkImageStrategy();
            }
            else
            {
                strategy = new FileImageStrategy();
            }
        }

        public string LoadImage()
        {
            return strategy.Load(href);
        }

        public override string OuterHTML(int indent = 0)
        {
            string space = new string(' ', indent);
            return $"{space}<img src=\"{href}\" />";
        }

        public override string InnerHTML()
        {
            return "";
        }
    }
}
