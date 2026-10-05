using AvaloniaEdit;

namespace Scrollium.Presentation.EditorExtensions;

public static class TextEditorParagraphExtensions
{
    public static void EnableParagraphSpacing(this TextEditor textEditor, double extraSpacing = 10.0, IBrush? caretBrush = null)
    {
        var textArea = textEditor.TextArea;
        var textView = textArea.TextView;

        // Quitamos el de por defecto
        textArea.Caret.CaretBrush = Brushes.Transparent;

        // Ponemos nuestro paragraph spacing xD
        textView.ElementGenerators.Add(new ParagraphSpacingGenerator { ExtraSpacing = Math.Abs(extraSpacing) });

        // Y ahora el cursos personalizado
        var customCaret = new CustomCaretRenderer(textArea, caretBrush ?? Brushes.DarkGray);
        textView.BackgroundRenderers.Add(customCaret);
    }
}