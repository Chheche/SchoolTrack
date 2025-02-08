namespace ProjetDevTest;

public partial class LireSession : ContentPage
{
    public LireSession()
    {
        InitializeComponent();
        DemanderSession();
    }

    private async Task DemanderSession()
    {
        HttpClient client = new HttpClient();
        String res = await client.GetStringAsync("https://fafa.kroko.xyz/~grasset/mauiwv/lireSession.php");

        labServeur.Text = res;

    }
}