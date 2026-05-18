namespace Task_1
{
    public abstract class SupportHandler
    {
        protected SupportHandler next;

        public void SetNext(SupportHandler nextHandler)
        {
            next = nextHandler;
        }

        public void Handle()
        {
            Process();

            Console.WriteLine("Did that help solve the problem?");
            Console.WriteLine("1 - Yes");
            Console.WriteLine("2 - No");

            int answer = int.Parse(Console.ReadLine());

            if (answer == 1)
            {
                Console.WriteLine("Thank you for contacting us!");
                return;
            }

            if (next != null)
            {
                next.Handle();
            }
            else
            {
                Console.WriteLine("None of the support levels helped.");
                Console.WriteLine("Please try again.\n");
            }
        }

        protected abstract void Process();
    }
}
