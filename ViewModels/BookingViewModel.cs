using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows.Input;
using The_Movies.Commands;
using The_Movies.Models;

public class BookingViewModel : INotifyPropertyChanged
{
    public event PropertyChangedEventHandler? PropertyChanged;
    private ForestillingRepository _forestillingRepository;

    private ObservableCollection<Forestilling> _forestillinger;

    public ObservableCollection<Forestilling> Forestillinger
    {
        get => _forestillinger;
        set
        {
            _forestillinger = value;
            OnPropertyChanged(nameof(Forestillinger));
        }
    }

    public BookingViewModel()
    {
        // Initialize the repository via the singleton instance
        _forestillingRepository = ForestillingRepository.Instance;
        Forestillinger = _forestillingRepository.GetAllForestillinger();
    }

    protected void OnPropertyChanged(string propertyName)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
