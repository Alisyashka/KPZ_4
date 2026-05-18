namespace Task_3_4
{
    public class EventListener : IEventListener
    {
        private readonly Action action;

        public EventListener(Action action)
        {
            this.action = action;
        }

        public void Update()
        {
            action();
        }
    }
}
