using ProjetDevTest.Classes;

namespace ProjetDevTest;

public partial class Profile : ContentPage
{
    private readonly Authentification _authService;

    public Profile(Authentification authService)
	{
		InitializeComponent();
        _authService = authService;
        //AfficherInfos();

    }

    //private void Button_Deco(object sender, EventArgs e)
    //{
    //    _authService.Logout();
    //    Shell.Current.GoToAsync($"{nameof(LoginPage)}");
    //}








    //private void AfficherInfos()
    //{
    //    infos.Text = "??" + Session.Cle + " " + Session.Mail;
    //}

    //// Pour rafra�chir les infos, parce que la page ne se met pas � jour
    //// automatiquement apr�s le premier affichage
    //private void ClicReload(object sender, EventArgs e)
    //{
    //    AfficherInfos();
    //}
}