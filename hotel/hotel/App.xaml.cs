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

        //public List<DadosUsuario> list_usuario = new List<DadosUsuario>
        public List<model.CategoriaQuarto> tipos_quartos = new List<model.CategoriaQuarto>()
        {
            new model.CategoriaQuarto()
            {
                Descricao = "SUÍTE FODA",
                ValorDiarioAdulto = 100.0,
                ValorDiarioCrianca = 50.0
            },

            new model.CategoriaQuarto()
            {
                Descricao = "SUÍTE 'MAI O MENOS'",
                ValorDiarioAdulto = 80.0,
                ValorDiarioCrianca = 40.0
            },

            new model.CategoriaQuarto()
            {
                Descricao = "SUÍTE HUMILDE",
                ValorDiarioAdulto = 60.0,
                ValorDiarioCrianca = 30.0

            }

        };

        public App()
        {
            InitializeComponent();
            Thread.CurrentThread.CurrentCulture = new CultureInfo("pt-BR");
            MainPage = new NavigationPage(new view.Protegida());
        }

        protected override void OnStart()
        {

        }

    }
}
