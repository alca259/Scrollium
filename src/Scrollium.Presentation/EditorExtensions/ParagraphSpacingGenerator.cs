using AvaloniaEdit.Rendering;
using System.Runtime.CompilerServices;

namespace Scrollium.Presentation.EditorExtensions;

public sealed class ParagraphSpacingGenerator : VisualLineElementGenerator
{
    private readonly ConditionalWeakTable<VisualLine, object> _processedLines = [];

    public double ExtraSpacing { get; set; }

    public ParagraphSpacingGenerator()
    {
    }

    /// <summary>Le indica al editor el punto exacto donde intervenir</summary>
    public override int GetFirstInterestedOffset(int startOffset)
    {
        var visualLine = CurrentContext.VisualLine;

        if (_processedLines.TryGetValue(visualLine, out _))
        {
            return -1;
        }

        int endOffset = visualLine.LastDocumentLine.EndOffset;
        return startOffset <= endOffset ? endOffset : -1;
    }

    public override VisualLineElement ConstructElement(int offset)
    {
        var visualLine = CurrentContext.VisualLine;
        _processedLines.AddOrUpdate(visualLine, true);

        double fontSize = CurrentContext.GlobalTextRunProperties.FontRenderingEmSize;
        double baseLineHeight = fontSize > 0 ? fontSize * 1.35 : 18.0;

        var spacer = new Border
        {
            Width = 0, // Separador transparente de ancho 0
            Height = baseLineHeight + ExtraSpacing
        };

        return new InlineObjectElement(
            documentLength: 0, // si no es 0 revienta cuando no hay texto, no sé que función cumple esto
            element: spacer);
    }
}
