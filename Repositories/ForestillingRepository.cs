using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Windows;
using The_Movies.Models;

// Denne klasse er en singleton, hvilket betyder at der kun kan eksistere én instans af klassen ad gangen
// fordi vi ikke har persistens (endnu?) bruges singleton til at sørge for, at alle bruger det samme instans af klassen og dermed den samme data.
// ellers får vi et nyt instans af klassen hver gang vi kalder new FilmRepository() og dermed en ny (tom) liste af film hver gang.

public class ForestillingRepository
{
    private static ForestillingRepository _instance;
    private static readonly object _lock = new object();

    private ObservableCollection<Forestilling> _forestillinger;

    private ForestillingRepository()
    {
        _forestillinger = new ObservableCollection<Forestilling>();
    }

    public static ForestillingRepository Instance
    {
        get
        {
            lock (_lock)
            {
                if (_instance == null)
                {
                    _instance = new ForestillingRepository();
                }
                return _instance;
            }
        }
    }

    public void AddForestilling(Forestilling forestilling)
    {
        if (forestilling != null)
        {
            _forestillinger.Add(forestilling);
            MessageBox.Show($"Forestillingen er blevet tilføjet til listen. Antal forestillinger: {_forestillinger.Count}");
        }
        else
        {
            MessageBox.Show("Fejl: Forestillingen kunne ikke tilføjes til listen.");
        }
    }

    public ObservableCollection<Forestilling> GetAllForestillinger()
    {
        Debug.WriteLine("Retrieving all forestillinger from repository");
        return _forestillinger;
    }

    public bool AreForestillingerOverlapping(Forestilling forestilling, DateTime startTime, DateTime endTime)
    {
        return _forestillinger.Any(f =>
            f.Cinema == forestilling.Cinema &&
            f.Town == forestilling.Town &&
            f.CinemaHall == forestilling.CinemaHall &&
            f.Day == forestilling.Day &&
            (
                (f.StartTime < endTime && f.EndTime > startTime)
            )
        );
    }
}
