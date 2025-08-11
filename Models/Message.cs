using System.ComponentModel;

namespace ERPChantier.Models
{
    public class Message : INotifyPropertyChanged
    {
        private string _text = string.Empty;
        private DateTime _timestamp;
        private bool _isFromCurrentUser;
        private bool _isRead;

        public string Text
        {
            get => _text;
            set
            {
                _text = value;
                OnPropertyChanged(nameof(Text));
            }
        }

        public DateTime Timestamp
        {
            get => _timestamp;
            set
            {
                _timestamp = value;
                OnPropertyChanged(nameof(Timestamp));
            }
        }

        public bool IsFromCurrentUser
        {
            get => _isFromCurrentUser;
            set
            {
                _isFromCurrentUser = value;
                OnPropertyChanged(nameof(IsFromCurrentUser));
            }
        }

        public bool IsRead
        {
            get => _isRead;
            set
            {
                _isRead = value;
                OnPropertyChanged(nameof(IsRead));
            }
        }

        public string TimeString => Timestamp.ToString("HH:mm");

        public event PropertyChangedEventHandler? PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
