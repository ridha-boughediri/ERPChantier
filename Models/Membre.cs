using System.ComponentModel;

namespace ERPChantier.Models
{
    public class Membre : INotifyPropertyChanged
    {
        private string _nom = string.Empty;
        private string _prenom = string.Empty;
        private string _role = string.Empty;
        private string _telephone = string.Empty;
        private string _email = string.Empty;
        private string _specialite = string.Empty;
        private bool _estActif;
        private DateTime _dateAjout;

        public string Nom
        {
            get => _nom;
            set
            {
                _nom = value;
                OnPropertyChanged(nameof(Nom));
                OnPropertyChanged(nameof(NomComplet));
            }
        }

        public string Prenom
        {
            get => _prenom;
            set
            {
                _prenom = value;
                OnPropertyChanged(nameof(Prenom));
                OnPropertyChanged(nameof(NomComplet));
            }
        }

        public string Role
        {
            get => _role;
            set
            {
                _role = value;
                OnPropertyChanged(nameof(Role));
            }
        }

        public string Telephone
        {
            get => _telephone;
            set
            {
                _telephone = value;
                OnPropertyChanged(nameof(Telephone));
            }
        }

        public string Email
        {
            get => _email;
            set
            {
                _email = value;
                OnPropertyChanged(nameof(Email));
            }
        }

        public string Specialite
        {
            get => _specialite;
            set
            {
                _specialite = value;
                OnPropertyChanged(nameof(Specialite));
            }
        }

        public bool EstActif
        {
            get => _estActif;
            set
            {
                _estActif = value;
                OnPropertyChanged(nameof(EstActif));
            }
        }

        public DateTime DateAjout
        {
            get => _dateAjout;
            set
            {
                _dateAjout = value;
                OnPropertyChanged(nameof(DateAjout));
            }
        }

        public string NomComplet => $"{Prenom} {Nom}";

        public string Initiales => $"{(Prenom.Length > 0 ? Prenom[0] : ' ')}{(Nom.Length > 0 ? Nom[0] : ' ')}".Trim();

        public string CouleurRole => Role switch
        {
            "Chef de chantier" => "#FF6B35",
            "Architecte" => "#004E89",
            "Ingénieur" => "#1A659E",
            "Ouvrier" => "#F77F00",
            "Électricien" => "#FCBF49",
            "Plombier" => "#003566",
            _ => "#9E9E9E"
        };

        public event PropertyChangedEventHandler? PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
