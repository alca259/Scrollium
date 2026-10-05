using Scrollium.Presentation.EditorExtensions;

namespace Scrollium.Presentation.Views;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        Editor.EnableParagraphSpacing(10.0);
    }
}
