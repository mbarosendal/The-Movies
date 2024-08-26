using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using The_Movies.Commands;
using The_Movies.Models;
using The_Movies.Repositories;

namespace The_Movies.ViewModels
{
    public class MainViewModel
    {
        public ObservableCollection<Film> Movies { get; }
        private FilmRepository _filmRepository { get; set; }
        public ICommand AddCommand { get; }
        public ICommand RemoveCommand { get; }
        public ICommand ClearCommand { get; }
        Film MovieToAdd { get; set; }

        public MainViewModel()
        {
            AddCommand = new RelayCommand(x => AddMovie(), x => CanAddMovie(x));
            //RemoveCommand = new RelayCommand(x => RemoveMovie(x), x => CanRemoveMovie(x));
            ClearCommand = new RelayCommand(x => ClearMovie(x));
            _filmRepository = new FilmRepository();
            Movies = new ObservableCollection<Film>(_filmRepository.GetAllMovies());
            MovieToAdd = new Film();
        }

        //private bool CanClearMovie(object x)
        //{
        //    throw new NotImplementedException();
        //}

        private void ClearMovie(object x)
        {
            throw new NotImplementedException();
        }

        //private bool CanRemoveMovie(object x)
        //{
        //    throw new NotImplementedException();
        //}

        //private void RemoveMovie(object x)
        //{
        //    throw new NotImplementedException();
        //}

        private bool CanAddMovie(object x)
        {
            return true;
        }

        private void AddMovie()
        {
            //// Tjekker om filmen allerede er tilføjet
            //if (_filmRepository.IsMovieAlreadyAdded(MovieToAdd.Title))
            //{
            //    MessageBox.Show("The movie with the title '" + MovieToAdd.Title + "' already exists.");
            //    return;
            //}

            try
            {
                // Lav nyt film objekt med data fra MovieToAdd
                Film newMovie = new Film
                {
                    Title = MovieToAdd.Title,
                    Duration = MovieToAdd.Duration,
                    Genre = MovieToAdd.Genre,
                    Director = MovieToAdd.Director,
                    PremiereDate = MovieToAdd.PremiereDate
                };

                _filmRepository.AddMovie(newMovie);
                Movies.Add(newMovie);

                // Behøver måske update af UI eller andre kompunenter.
                //UpdateMovieListView();

                _filmRepository.SaveMoviesAsync();
                _filmRepository.SaveMoviesToCSV();

                MessageBox.Show("Filmen er nu gemt!");
            }
            catch (Exception ex)
            {
                // Error håndtering
                MessageBox.Show("Fejl opstod under tilføjelse af film: " + ex.Message);
            }
        }

    }
}
