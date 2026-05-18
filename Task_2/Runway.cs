namespace Task_2
{
    class Runway
    {
        public readonly Guid Id = Guid.NewGuid();
        private CommandCentre _mediator;

        public bool IsBusy { get; private set; }

        public Runway(CommandCentre mediator)
        {
            _mediator = mediator;
        }

        public void SetBusy()
        {
            IsBusy = true;
            HighLightRed();
        }

        public void SetFree()
        {
            IsBusy = false;
            HighLightGreen();
        }

        public void HighLightRed()
        {
            Console.WriteLine($"Runway {Id} is busy!");
        }

        public void HighLightGreen()
        {
            Console.WriteLine($"Runway {Id} is free!");
        }
    }
}
