namespace Task_2
{
    class CommandCentre
    {
        private List<Runway> _runways = new List<Runway>();
        private Dictionary<Aircraft, Runway> _aircraftRunwayMap = new Dictionary<Aircraft, Runway>();

        public void RegisterRunway(Runway runway)
        {
            _runways.Add(runway);
        }

        public void RegisterAircraft(Aircraft aircraft)
        {
            _aircraftRunwayMap[aircraft] = null;
        }

        public void RequestLanding(Aircraft aircraft)
        {
            foreach (var runway in _runways)
            {
                if (!runway.IsBusy)
                {
                    Console.WriteLine($"Aircraft {aircraft.Name} is landing on runway {runway.Id}");
                    runway.SetBusy();
                    _aircraftRunwayMap[aircraft] = runway;
                    return;
                }
            }

            Console.WriteLine($"No free runway for {aircraft.Name}");
        }

        public void RequestTakeOff(Aircraft aircraft)
        {
            if (_aircraftRunwayMap.ContainsKey(aircraft) && _aircraftRunwayMap[aircraft] != null)
            {
                var runway = _aircraftRunwayMap[aircraft];

                Console.WriteLine($"Aircraft {aircraft.Name} is taking off from runway {runway.Id}");
                runway.SetFree();
                _aircraftRunwayMap[aircraft] = null;
            }
            else
            {
                Console.WriteLine($"Aircraft {aircraft.Name} is not on any runway");
            }
        }
    }
}
