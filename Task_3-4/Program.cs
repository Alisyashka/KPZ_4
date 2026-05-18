namespace Task_3_4
{
    internal class Program
    {
        static void Main()
        {
            LightElementNode button =
                new LightElementNode("button", "inline", "paired");

            button.AddClass("btn");
            button.AddChild(new LightTextNode("Press me"));

            button.AddEventListener("click", () =>
            {
                Console.WriteLine("Button clicked!");
            });

            Console.WriteLine("HTML:");
            Console.WriteLine(button.OuterHTML());

            Console.WriteLine("\nTrigger click:");
            button.TriggerEvent("click");



            Console.WriteLine("\n--- IMAGE TEST ---");

            LightImageNode localImage =
                new LightImageNode("images/photo.png");

            LightImageNode webImage =
                new LightImageNode("https://example.com/image.jpg");

            Console.WriteLine(localImage.OuterHTML());
            Console.WriteLine(localImage.LoadImage());

            Console.WriteLine();

            Console.WriteLine(webImage.OuterHTML());
            Console.WriteLine(webImage.LoadImage());
        }
    }
}