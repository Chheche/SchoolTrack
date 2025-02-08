using System.Diagnostics;
using System.Net.Http.Json;
using ProjetDevTest.Classes;

namespace ProjetDevTest;

public partial class LoginPage : ContentPage
{
    private readonly Authentification _authService;

    public LoginPage(Authentification authService)
	{
		InitializeComponent();
        _authService = authService; 
	}


    // regarde ds la classe Authentification si l utilisateur est déjà login
    /*
    protected async override void OnNavigatedTo(NavigatedToEventArgs args)
    {
        base.OnNavigatedTo(args);

        if(await _authService.IsLogedAsync()) 
        {
            // User is logged In
            // redirect to main page
            await Shell.Current.GoToAsync($"//{nameof(MainPage)}");
        }
        else
        {
            // user is NOT log in
            // redirect to loginPage
            await Shell.Current.GoToAsync($"//{nameof(LoginPage)}");
        }
    }*/




    private void Button_Connexion(object sender, EventArgs e)
    {
        DemanderConnexion(mail.Text, password.Text);

        mail.Text = "";
        password.Text = "";
    }


    private async void DemanderConnexion(String mail, String motPasse)
    {
        HttpClient client = new HttpClient();

        label.Text = "connexion...";

        if(mail == "coucou" && motPasse == "1234")
        {
            Session.Mail = "coucou";
            Session.MotPasse = "1234";
            Session.Cle = "";

            _authService.Login();

            await Shell.Current.GoToAsync($"{nameof(MainPage)}");
        }
        else
        {
            label.Text = "mail ou mot de passe incorrect !!!";
        }


        // regarder ds la bdd si le mail et mot de passe existe

        // si il existe => envoyer sur MainPage + prendre en session le mail, mot de passe et prenom

        // sinon le laisser sur connexion
    }
}