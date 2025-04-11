using Avalonia.ReactiveUI;
using MarkupExtensionClassesIssue.ViewModels;
using ReactiveUI;

namespace MarkupExtensionClassesIssue.Views;

public partial class MainView : ReactiveUserControl<MainViewModel>
{
    public MainView()
    {
        InitializeComponent();

        this.WhenActivated(_ =>
        {
            _markupExtensionButtonTextBlock.Text = $"ButtonClasses: {string.Join("; ", _markupExtensionButton.Classes)}\nCount: {_markupExtensionButton.Classes.Count}";
            _regularButtonTextBlock.Text = $"ButtonClasses: {string.Join("; ", _regularButton.Classes)}\nCount: {_regularButton.Classes.Count}";
        });
    }
}
