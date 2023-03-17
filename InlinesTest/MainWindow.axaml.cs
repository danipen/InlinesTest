using Avalonia.Controls;
using Avalonia.Controls.Documents;
using Avalonia.Media;

namespace InlinesTest
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            mUseInlinesButton.Click += UseInlinesButton_Click;
            mUseTextButton.Click += UseTextButton_Click;
        }

        private void UseTextButton_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            mTextBlock.Text = "WE SWITCHED TO USE TEXT";
            mTextBlock.Inlines?.Clear();
            mTextBlock.Inlines = null;
        }

        private void UseInlinesButton_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            mTextBlock.Text = null;
            mTextBlock.Inlines = new Avalonia.Controls.Documents.InlineCollection
            {
                new Run("NOW WE "),
                new Run("ARE USING ") { Background = Brushes.Pink },
                new Run("INLINES AND ") { Background = Brushes.LightCoral },
                new Run("THIS SHOULD WORK NOW ")
            };
        }
    }
}