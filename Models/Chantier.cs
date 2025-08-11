using System.ComponentModel;
using System.Collections.ObjectModel;

namespace ERPChantier.Models
{
    public class Chantier : INotifyPropertyChanged
    {
        private string _nom = string.Empty;
        private string _adresse = string.Empty;
        private DateTime _dateDebut;
        private DateTime _dateFin;
        private string _statut = string.Empty;
        private string _description = string.Empty;
        private double _progression;

        public string Nom
        {
            get => _nom;
            set
            {
                _nom = value;
                OnPropertyChanged(nameof(Nom));
            }
        }

        public string Adresse
        {
            get => _adresse;
            set
            {
                _adresse = value;
                OnPropertyChanged(nameof(Adresse));
            }
        }

        public DateTime DateDebut
        {
            get => _dateDebut;
            set
            {
                _dateDebut = value;
                OnPropertyChanged(nameof(DateDebut));
            }
        }

        public DateTime DateFin
        {
            get => _dateFin;
            set
            {
                _dateFin = value;
                OnPropertyChanged(nameof(DateFin));
            }
        }

        public string Statut
        {
            get => _statut;
            set
            {
                _statut = value;
                OnPropertyChanged(nameof(Statut));
            }
        }

        public string Description
        {
            get => _description;
            set
            {
                _description = value;
                OnPropertyChanged(nameof(Description));
            }
        }

        public double Progression
        {
            get => _progression;
            set
            {
                _progression = value;
                OnPropertyChanged(nameof(Progression));
            }
        }

        public ObservableCollection<Tache> Taches { get; set; } = new ObservableCollection<Tache>();
        public ObservableCollection<Membre> Equipe { get; set; } = new ObservableCollection<Membre>();

        public event PropertyChangedEventHandler? PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
