namespace Task_5
{
    class Program
    {
        static void Main()
        {
            TextEditor editor = new TextEditor();

            editor.Write("Hello");
            editor.Save();

            editor.Write("Hello World");
            editor.Save();

            editor.Write("Hello World!!!");

            Console.WriteLine("Current text:");
            Console.WriteLine(editor.GetText());

            editor.Undo();

            Console.WriteLine("\nAfter cancellation:");
            Console.WriteLine(editor.GetText());

            editor.Undo();

            Console.WriteLine("\nAnother cancellation:");
            Console.WriteLine(editor.GetText());
        }
    }
}