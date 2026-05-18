namespace Task_5
{
    class TextEditor
    {
        private TextDocument document = new TextDocument();
        private History history = new History();

        public void Write(string text)
        {
            document.Text = text;
        }

        public string GetText()
        {
            return document.Text;
        }

        public void Save()
        {
            history.Push(new Memento(document.Text));
        }

        public void Undo()
        {
            Memento memento = history.Pop();

            if (memento != null)
            {
                document.Text = memento.State;
            }
        }
    }
}