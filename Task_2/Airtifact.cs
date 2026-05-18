namespace Task_2
{
    class Aircraft
    {
        public string Name;
        public bool IsTakingOff { get; set; }
        private CommandCentre _mediator;

        public Aircraft(string name, CommandCentre mediator)
        {
            Name = name;
            _mediator = mediator;
        }

        public void Land()
        {
            Console.WriteLine($"Aircraft {Name} requests landing.");
            _mediator.RequestLanding(this);
        }

        public void TakeOff()
        {
            Console.WriteLine($"Aircraft {Name} requests takeoff.");
            IsTakingOff = true;
            _mediator.RequestTakeOff(this);
        }
    }
}