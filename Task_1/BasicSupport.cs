namespace Task_1
{
    public class BasicSupport : SupportHandler
    {
        protected override void Process()
        {
            Console.WriteLine("\n[Level 1] Basic support:");
            Console.WriteLine("Check to see if the device is turned on.");
        }
    }

}
