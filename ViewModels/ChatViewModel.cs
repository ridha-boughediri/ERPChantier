using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Input;
using Contact = ERPChantier.Models.Contact;
using ERPChantier.Models;

namespace ERPChantier.ViewModels
{
    public class ChatViewModel : INotifyPropertyChanged
    {
        private string _messageText = string.Empty;
        private Contact _currentContact;
        private bool _isTyping;

        public ObservableCollection<Message> Messages { get; set; }
        public ICommand SendMessageCommand { get; }

        public ChatViewModel()
        {
            Messages = new ObservableCollection<Message>();
            SendMessageCommand = new Command(SendMessage, CanSendMessage);
            
            // Contact par défaut pour la démo
            CurrentContact = new Contact
            {
                Name = "Équipe Chantier",
                IsOnline = true,
                ProfileImageUrl = "https://via.placeholder.com/50"
            };

            // Messages de démonstration
            LoadSampleMessages();
        }

        public string MessageText
        {
            get => _messageText;
            set
            {
                _messageText = value;
                OnPropertyChanged(nameof(MessageText));
                ((Command)SendMessageCommand).ChangeCanExecute();
            }
        }

        public Contact CurrentContact
        {
            get => _currentContact;
            set
            {
                _currentContact = value;
                OnPropertyChanged(nameof(CurrentContact));
            }
        }

        public bool IsTyping
        {
            get => _isTyping;
            set
            {
                _isTyping = value;
                OnPropertyChanged(nameof(IsTyping));
            }
        }

        private void SendMessage()
        {
            if (string.IsNullOrWhiteSpace(MessageText))
                return;

            var message = new Message
            {
                Text = MessageText.Trim(),
                Timestamp = DateTime.Now,
                IsFromCurrentUser = true,
                IsRead = true
            };

            Messages.Add(message);
            MessageText = string.Empty;

            // Simuler une réponse automatique après 2 secondes
            Task.Delay(2000).ContinueWith(_ =>
            {
                var responses = new[]
                {
                    "Message reçu !",
                    "Parfait, merci pour l'info",
                    "Je vais vérifier ça",
                    "Compris, on s'en occupe",
                    "Merci pour la mise à jour"
                };

                var random = new Random();
                var response = responses[random.Next(responses.Length)];

                var replyMessage = new Message
                {
                    Text = response,
                    Timestamp = DateTime.Now,
                    IsFromCurrentUser = false,
                    IsRead = false
                };

                MainThread.BeginInvokeOnMainThread(() =>
                {
                    Messages.Add(replyMessage);
                });
            });
        }

        private bool CanSendMessage()
        {
            return !string.IsNullOrWhiteSpace(MessageText);
        }

        private void LoadSampleMessages()
        {
            var sampleMessages = new[]
            {
                new Message
                {
                    Text = "Bonjour ! Comment avance le chantier aujourd'hui ?",
                    Timestamp = DateTime.Now.AddHours(-2),
                    IsFromCurrentUser = false,
                    IsRead = true
                },
                new Message
                {
                    Text = "Salut ! Tout se passe bien, nous avons terminé la fondation ce matin.",
                    Timestamp = DateTime.Now.AddHours(-1).AddMinutes(-45),
                    IsFromCurrentUser = true,
                    IsRead = true
                },
                new Message
                {
                    Text = "Excellent ! Avez-vous des photos à partager ?",
                    Timestamp = DateTime.Now.AddHours(-1).AddMinutes(-30),
                    IsFromCurrentUser = false,
                    IsRead = true
                },
                new Message
                {
                    Text = "Oui, je vais les envoyer dans quelques minutes.",
                    Timestamp = DateTime.Now.AddMinutes(-15),
                    IsFromCurrentUser = true,
                    IsRead = true
                }
            };

            foreach (var message in sampleMessages)
            {
                Messages.Add(message);
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
