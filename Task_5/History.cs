namespace Task_5
{
    class History
    {
        private Stack<Memento> states = new Stack<Memento>();

        public void Push(Memento memento)
        {
            states.Push(memento);
        }

        public Memento Pop()
        {
            if (states.Count > 0)
            {
                return states.Pop();
            }

            return null;
        }
    }
}