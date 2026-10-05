using AvaloniaEdit.Editing;
using AvaloniaEdit.Rendering;

namespace Scrollium.Presentation.EditorExtensions;

public sealed class CustomCaretRenderer : IBackgroundRenderer
{
    private readonly TextArea _textArea;
    private readonly IBrush _caretBrush;

    public CustomCaretRenderer(TextArea textArea, IBrush? caretBrush = null)
    {
        _textArea = textArea;
        _caretBrush = caretBrush ?? Brushes.Black;
    }

    public KnownLayer Layer => KnownLayer.Caret;

    public void Draw(TextView textView, DrawingContext drawingContext)
    {
        var caret = _textArea.Caret;
        if (caret == null)
            return;

        VisualLine? visualLine = textView.GetVisualLine(caret.Line);
        if (visualLine == null)
            return;

        int visualColumn = caret.VisualColumn;
        Point visualPos = visualLine.GetVisualPosition(visualColumn, VisualYPosition.LineTop);

        double x = visualPos.X - textView.ScrollOffset.X;
        double y = visualPos.Y - textView.ScrollOffset.Y;

        double fontSize = _textArea.FontSize;
        double height = fontSize > 0 ? fontSize * 1.35 : 14.0;

        drawingContext.FillRectangle(_caretBrush, new Rect(x, y, 1.0, height));
    }
}
