using System.ComponentModel;

namespace ERPChantier.Models
{
    public class Tache : INotifyPropertyChanged
    {
        private string _titre = string.Empty;
        private string _description = string.Empty;
        private string _statut = string.Empty;
        private string _priorite = string.Empty;
        private DateTime _dateCreation;
        private DateTime? _dateEcheance;
        private string _assigneA = string.Empty;
        private bool _estTerminee;

        public string Titre
        {
            get => _titre;
            set
            {
                _titre = value;
                OnPropertyChanged(nameof(Titre));
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

        public string Statut
        {
            get => _statut;
            set
            {
                _statut = value;
                OnPropertyChanged(nameof(Statut));
            }
        }

        public string Priorite
        {
            get => _priorite;
            set
            {
                _priorite = value;
                OnPropertyChanged(nameof(Priorite));
            }
        }

        public DateTime DateCreation
        {
            get => _dateCreation;
            set
            {
                _dateCreation = value;
                OnPropertyChanged(nameof(DateCreation));
            }
        }

        public DateTime? DateEcheance
        {
            get => _dateEcheance;
            set
            {
                _dateEcheance = value;
                OnPropertyChanged(nameof(DateEcheance));
            }
        }

        public string AssigneA
        {
            get => _assigneA;
            set
            {
                _assigneA = value;
                OnPropertyChanged(nameof(AssigneA));
            }
        }

        public bool EstTerminee
        {
            get => _estTerminee;
            set
            {
                _estTerminee = value;
                OnPropertyChanged(nameof(EstTerminee));
            }
        }

        public string CouleurPriorite => Priorite switch
        {
            "Haute" => "#FF4444",
            "Moyenne" => "#FFA500",
            "Basse" => "#4CAF50",
            _ => "#9E9E9E"
        };

        public event PropertyChangedEventHandler? PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
