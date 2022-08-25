using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Collections.Generic;

using hotel.model;
using hotel.view;

namespace hotel
{
    public partial class App : Application
    {

        public List<DadosUsuario> list_usuario = new List<DadosUsuario>
        {
            new DadosUsuario()
            {
                Email = "apaulinineto@gmail.com",
                Nome = "Adib", 
                Senha = "123"

            }

        };
        public App()
        {
            InitializeComponent();
            if (Properties.ContainsKey("usuario_logado"))
                MainPage = new Protegida();
            else
            MainPage = new Login();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
