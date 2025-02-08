using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetDevTest.Classes
{
    public class Authentification
    {
        private const string Autentifier = "AuthState";


        // permet de savoir si l'utilisateur est déja connecte
        public async Task<bool> IsLogedAsync()
        {
            await Task.Delay(2000);

            var AuthState  = Preferences.Default.Get<bool>(Autentifier, false);

            return AuthState;
        }


        public void Login()
        {
            Preferences.Default.Set<bool>(Autentifier, true);
        }

        public void Logout()
        {
            Preferences.Default.Remove(Autentifier);
        }
    }
}
