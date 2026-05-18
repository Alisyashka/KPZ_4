namespace Task_1
{
    public class SupportMenu
    {
        private SupportHandler handler;

        public SupportMenu(SupportHandler handler)
        {
            this.handler = handler;
        }

        public void Start()
        {
            while (true)
            {
                Console.WriteLine("=== Customer Support ===");
                Console.WriteLine("Press 1 to begin");
                Console.WriteLine("0 - Exit");

                int choice = int.Parse(Console.ReadLine());

                if (choice == 0)
                    break;

                if (choice == 1)
                {
                    handler.Handle();
                }
            }
        }
    }
}
