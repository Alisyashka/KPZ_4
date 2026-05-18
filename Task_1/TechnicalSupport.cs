namespace Task_1
{
    public class TechnicalSupport : SupportHandler
    {
        protected override void Process()
        {
            Console.WriteLine("\n[level 3] Technical Support:");
            Console.WriteLine("Try restarting the system.");
        }
    }
}
