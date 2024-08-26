using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;
using The_Movies.ViewModels;

namespace The_Movies
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
  
        //timeZone
        private TimeZoneInfo cetZone = TimeZoneInfo.FindSystemTimeZoneById("Central European Standard Time");
        private DispatcherTimer timer;

        public MainWindow()
        {
            InitializeComponent();
            //LoadVisningerFromFile();
            DataContext = new MainViewModel();
        }

        private void PopulateTimeSlots()
        {

            cbSpilletid.Items.Clear();

            DateTime now = TimeZoneInfo.ConvertTime(DateTime.Now, cetZone);
            DateTime endTime = now.AddHours(24); // 24 hour timer
            for (DateTime time = now; time <= endTime; time = time.AddHours(1))
            {
                cbSpilletid.Items.Add(time.ToString("HH:mm"));
            }
        }
    }
}