using ERPChantier.ViewModels;

namespace ERPChantier.Views;

public partial class ChatPage : ContentPage
{
    private ChatViewModel _viewModel;

    public ChatPage()
    {
        InitializeComponent();
        _viewModel = new ChatViewModel();
        BindingContext = _viewModel;
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();
        
        // Faire défiler vers le bas pour afficher les derniers messages
        if (MessagesCollectionView.ItemsSource != null)
        {
            var messages = _viewModel.Messages;
            if (messages.Count > 0)
            {
                MessagesCollectionView.ScrollTo(messages.Last(), position: ScrollToPosition.End, animate: false);
            }
        }
    }
}
