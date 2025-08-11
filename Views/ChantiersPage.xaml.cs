namespace ERPChantier.Views;

public partial class ChantiersPage : ContentPage
{
    public ChantiersPage()
    {
        InitializeComponent();
    }

    private async void OnOpenKanbanClicked(object sender, EventArgs e)
    {
        // Navigation vers la page de détail du chantier avec le drawer Kanban
        await Shell.Current.GoToAsync("//chantierdetail");
    }
}
