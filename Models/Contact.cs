using System.ComponentModel;

namespace ERPChantier.Models
{
    public class Contact : INotifyPropertyChanged
    {
        private string _name = string.Empty;
        private string _profileImageUrl = string.Empty;
        private bool _isOnline;
        private DateTime _lastSeen;

        public string Name
        {
            get => _name;
            set
            {
                _name = value;
                OnPropertyChanged(nameof(Name));
            }
        }

        public string ProfileImageUrl
        {
            get => _profileImageUrl;
            set
            {
                _profileImageUrl = value;
                OnPropertyChanged(nameof(ProfileImageUrl));
            }
        }

        public bool IsOnline
        {
            get => _isOnline;
            set
            {
                _isOnline = value;
                OnPropertyChanged(nameof(IsOnline));
            }
        }

        public DateTime LastSeen
        {
            get => _lastSeen;
            set
            {
                _lastSeen = value;
                OnPropertyChanged(nameof(LastSeen));
            }
        }

        public string StatusText => IsOnline ? "En ligne" : $"Vu pour la dernière fois {LastSeen:HH:mm}";

        public event PropertyChangedEventHandler? PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
