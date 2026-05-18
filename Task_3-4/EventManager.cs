namespace Task_3_4
{
    public class EventManager
    {
        private Dictionary<string, List<IEventListener>> listeners =
            new Dictionary<string, List<IEventListener>>();

        public void Subscribe(string eventType, IEventListener listener)
        {
            if (!listeners.ContainsKey(eventType))
            {
                listeners[eventType] = new List<IEventListener>();
            }

            listeners[eventType].Add(listener);
        }

        public void Notify(string eventType)
        {
            if (!listeners.ContainsKey(eventType))
            {
                Console.WriteLine("Event not found: " + eventType);
                return;
            }

            foreach (var listener in listeners[eventType])
            {
                listener.Update();
            }
        }
    }
}
