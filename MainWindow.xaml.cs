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

namespace The_Movies
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // Filepath
        private string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "FilmListe.csv");
        private string visningFilePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "OversigtVisninger.csv");

        //timeZone
        private TimeZoneInfo cetZone = TimeZoneInfo.FindSystemTimeZoneById("Central European Standard Time");
        private DispatcherTimer timer;

        public MainWindow()
        {

        InitializeComponent();
        LoadVisningerFromFile();
        InitializeTimer();

        }

        private void PopulateTimeSlots()
        {

        cbSpilletid.Items.Clear();
        
        DateTime now = TimeZoneInfo.ConvertTime(DateTime.Now, cetZone);
        DateTime endTime = now.AddHours(24); // 24 hour timer
        for (DateTime time = now; time <=endTime; time = time.AddHour(1))
        {
            cbSpilletid.Item.add(time.ToString("HH:mm"));
        }

        }

    }

}