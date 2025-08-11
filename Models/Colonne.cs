using System.ComponentModel;
using System.Collections.ObjectModel;

namespace ERPChantier.Models
{
    public class Colonne : INotifyPropertyChanged
    {
        private string _nom = string.Empty;
        private string _couleur = string.Empty;
        private int _ordre;
        private int _limiteTaches;

        public string Nom
        {
            get => _nom;
            set
            {
                _nom = value;
                OnPropertyChanged(nameof(Nom));
            }
        }

        public string Couleur
        {
            get => _couleur;
            set
            {
                _couleur = value;
                OnPropertyChanged(nameof(Couleur));
            }
        }

        public int Ordre
        {
            get => _ordre;
            set
            {
                _ordre = value;
                OnPropertyChanged(nameof(Ordre));
            }
        }

        public int LimiteTaches
        {
            get => _limiteTaches;
            set
            {
                _limiteTaches = value;
                OnPropertyChanged(nameof(LimiteTaches));
            }
        }

        public ObservableCollection<Tache> Taches { get; set; } = new ObservableCollection<Tache>();

        public int NombreTaches => Taches.Count;

        public bool EstPleine => LimiteTaches > 0 && NombreTaches >= LimiteTaches;

        public event PropertyChangedEventHandler? PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
