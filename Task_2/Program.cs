namespace Task_2
{
    class Program
    {
        static void Main()
        {
            var commandCentre = new CommandCentre();

            var runway1 = new Runway(commandCentre);
            var runway2 = new Runway(commandCentre);

            commandCentre.RegisterRunway(runway1);
            commandCentre.RegisterRunway(runway2);

            var aircraft1 = new Aircraft("Boeing 737", commandCentre);
            var aircraft2 = new Aircraft("Airbus A320", commandCentre);

            commandCentre.RegisterAircraft(aircraft1);
            commandCentre.RegisterAircraft(aircraft2);

            aircraft1.Land();
            aircraft2.Land();

            aircraft1.TakeOff();
            aircraft2.TakeOff();
        }
    }
}
