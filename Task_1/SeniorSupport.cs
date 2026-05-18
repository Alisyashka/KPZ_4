namespace Task_1
{
    public class SeniorSupport : SupportHandler
    {
        protected override void Process()
        {
            Console.WriteLine("\n[Level 4] Senior Specialist:");
            Console.WriteLine("Your request has been forwarded for manual processing.");
        }
    }
}
