using MVVMSample001.ViewModels;
using System.Windows;

namespace MVVMSample001.Views
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MainWindowViewModel();
        }
    }
}
