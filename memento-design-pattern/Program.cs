using memento_design_pattern.command;
using memento_design_pattern.editor;

internal class Program
{
    private static void Main(string[] args)
    {
        IEditor editor = new Editor("Text", 100, 200, 300);
        ICommand command = new Command(editor);
        command.MakeBackup();
        editor.SetCursorX(1911);
        editor.SetText("Another text");
        Console.WriteLine(editor);
        command.Undo();
        Console.WriteLine(editor);
    }
}