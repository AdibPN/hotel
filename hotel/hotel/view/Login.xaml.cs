using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using hotel;

namespace hotel.view
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        App PropriedadesApp;

        //List<DadosUsuario> list_usuario;

        public Login()
        {
            InitializeComponent();

            PropriedadesApp = (App)Application.Current;


        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            try
            {
                string email = User_email.Text;
                string senha = user_pw.Text;

                string email_correto = "aluno@etec";
                string senha_correta = "123";


                if (email == email_correto && senha == senha_correta)
                {
                    App.Current.Properties.Add("usuario_logado", email);
                    App.Current.MainPage = new Protegida();
                }
                else
                    throw new Exception("Dados incorretos, tente novamente.");

            }
            catch (Exception ex)
            {
                DisplayAlert("Ops!", ex.Message, "OK");
            }
        }
    }
}