using System.Diagnostics;
using ProjetDevTest.Classes;

namespace ProjetDevTest
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            //verifierConnexion(Session.Mail, Session.MotPasse);
        }


    //    public async void verifierConnexion(string mail, string motpasse)
    //    {
    //        if (!(string.IsNullOrEmpty(mail) && string.IsNullOrEmpty(motpasse)))
    //        {
    //            Console.WriteLine("connecte, yahou");
    //            labeltest.Text = Session.MotPasse;
    //        }
    //        else
    //        {
    //            Console.WriteLine("pas connecte, bouuuuuuuuuhhhhhhh");
    //            labeltest.Text = Session.MotPasse;
    //        }
    //    }

    //    private void DemanderConnexion(object sender, EventArgs e)
    //    {
    //        EnvoyerDemande(inLogin.Text, inPass.Text);
    //    }

    //    private async void EnvoyerDemande(String login, String pass)
    //    {

    //        if (!(string.IsNullOrEmpty(login) && string.IsNullOrEmpty(pass)))
    //        {

    //        }
    //        //HttpClient client = new HttpClient();
    //        //String reponse = await client.GetStringAsync("https://fafa.kroko.xyz/~grasset/mauiwv/identification.php?login=" + login + "&pass=" + pass);

    //        //Debug.WriteLine(reponse);

    //        //String[] elements = reponse.Split("**");
    //        //Session.Cle = elements[0];
    //        //Session.Login = elements[1];
    //        //Session.Nom = elements[2];
    //        //Session.Prenom = elements[3];

    //        //foreach (String element in elements)
    //        //{
    //        //    Debug.WriteLine(element);
    //        //}
    //    }
    }

}
