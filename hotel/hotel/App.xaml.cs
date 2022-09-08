using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;

using hotel.model;
using hotel.view;

namespace hotel
{
    public partial class App : Application
    {

        public List<DadosUsuario> list_usuarios = new List<DadosUsuario>
        {
            new DadosUsuario()
            {
                Email = "aluno@etec",
                Nome = "Aluno",
                Senha = "123"
            },
            new DadosUsuario()
            {
                Email = "prof@etec",
                Nome = "Professor",
                Senha = "456"
            }
        };

        //public List<DadosUsuario> list_usuario = new List<DadosUsuario>
        public List<model.CategoriaQuarto> tipos_quartos = new List<model.CategoriaQuarto>()
        {
            new model.CategoriaQuarto()
            {
                Descricao = "SUÍTE FODA",
                ValorDiariaAdulto = 100.0,
                ValorDiariaCrianca = 50.0
            },

            new model.CategoriaQuarto()
            {
                Descricao = "SUÍTE 'MAI O MENOS'",
                ValorDiariaAdulto = 80.0,
                ValorDiariaCrianca = 40.0
            },

            new model.CategoriaQuarto()
            {
                Descricao = "SUÍTE HUMILDE",
                ValorDiariaAdulto = 60.0,
                ValorDiariaCrianca = 30.0

            },

            new model.CategoriaQuarto()
            {
                Descricao = "SUÍTE INFLACIONARIA",
                ValorDiariaAdulto = 50.0,
                ValorDiariaCrianca = 25.0

            }

        };

        public App()
        {
            InitializeComponent();
            Thread.CurrentThread.CurrentCulture = new CultureInfo("pt-BR");

            if (Properties.ContainsKey("usuario_logado"))
                MainPage = new NavigationPage(new view.HospedagemCalculada());
            else
                MainPage = new view.Login();
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
