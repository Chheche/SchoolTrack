using System.Diagnostics;

namespace ProjetDevTest;

public partial class EcrireSession : ContentPage
{
	public EcrireSession()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
        Ecrire(inputNom.Text, inputTexte.Text);
    }

    private async void Ecrire(String nom, String val)
    {
        HttpClient httpClient = new HttpClient();


        String reponse = await httpClient.GetStringAsync("https://fafa.kroko.xyz/~grasset/mauiwv/ecrireSession.php?" + nom + "=" + val);

        Debug.WriteLine("Yep : " + reponse);
    }
}