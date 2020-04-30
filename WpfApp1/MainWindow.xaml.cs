using AsyncCommands;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = new MainWindowViewModel();
        }
    }
    public class MainWindowViewModel
    {
        public ICommand Command { get; set; }
        public MainWindowViewModel()
        {
            Command = new AsyncCommand<string>(oncommandAsync);
        }

        private async Task oncommandAsync(string arg)
        {
            await Task.Delay(3000).ConfigureAwait(true);
        }

        //private async Task oncommandAsync()
        //{
        //    await Task.Delay(3000);
        //}
    }

}
