using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using hotel.model;

namespace hotel.view
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Protegida : ContentPage
    {
        App PropriedadesApp;

        public Protegida()
        {
            InitializeComponent();

            PropriedadesApp = (App)Application.Current;

            pck_quarto.ItemsSource = PropriedadesApp.tipos_quartos;

            //lbl_usuario.Text = App.Current.Properties["usuario_logado"].ToString();

            pck_quarto.ItemsSource = PropriedadesApp.tipos_quartos;

            dtpck_data_checkin.MinimumDate = DateTime.Now;
            dtpck_data_checkin.MaximumDate = DateTime.Now.AddMonths(6);

            dtpck_data_checkout.MinimumDate = DateTime.Now.AddDays(1);
            dtpck_data_checkout.MaximumDate = DateTime.Now.AddMonths(6).AddDays(1);


        }

        private async void BtnCalcular_Clicked(object sender, EventArgs e)
        {
            try
            {
                int qnt_adultos = Convert.ToInt32(quantidade_adultos.Text);
                int qnt_criancas = Convert.ToInt32(quantidade_crianca.Text);

                if (qnt_adultos == 0 && qnt_criancas == 0)
                    throw new Exception("Desculpe, informe pelo menos um adulto ou uma criança");
                model.CategoriaQuarto quarto_selecionado = (model.CategoriaQuarto)pck_quarto.SelectedItem;

                if (quarto_selecionado == null)
                    throw new Exception("Desculpe, selecione um quarto.");


                model.Hospedagem dados_hospedagem = new model.Hospedagem()
                {
                    Quarto = quarto_selecionado,
                    QuantidadeAdultos = qnt_adultos,
                    QuantidadeCriancas = qnt_criancas,

                    QuantidadeDias = model.Hospedagem.CalcularTempoEstadia(dtpck_data_checkin.Date, dtpck_data_checkout.Date),

                    DataCheckIn = dtpck_data_checkin.Date,
                    DataCheckOut = dtpck_data_checkout.Date,

                };

                dados_hospedagem.ValorTotal = dados_hospedagem.CalcularValorEstadia();


                var SegundaTela = new HospedagemCalculada();
                SegundaTela.BindingContext = dados_hospedagem;
                await Navigation.PushAsync(SegundaTela);
            } catch (Exception ex)
            {
                await DisplayAlert("Ops!", ex.Message, "OK");
            }
        }

    }
}  
