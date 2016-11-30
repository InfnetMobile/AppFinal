using System;
using System.Collections.Generic;
using System.Diagnostics;

using Xamarin.Forms;

namespace InfoNews
{
	public partial class InfoNewsPage : ContentPage
	{
		public static bool btnPlantaoClicked = false;
		public static bool btnEsporteClicked = false;
		public static bool btnEconomiaClicked = false;
		public static bool btnMundoClicked = false;
		public static bool btnTecnologiaClicked = false;

		public InfoNewsPage()
		{
			InitializeComponent();

			this.Title = "Info News";
		}

		async void BotaoSair(object sender, EventArgs e)
		{
			App.UsuarioLogado = false;
			Navigation.InsertPageBefore(new LoginPage(), this);
			await Navigation.PopAsync();
		}

		private async void BtnPlantao(object sender, EventArgs args)
		{
			btnPlantaoClicked = true;
			await Navigation.PushAsync(new ListaInformacaoPage());
		}

		private async void BtnEsporte(object sender, EventArgs args)
		{
			btnEsporteClicked = true;
			await Navigation.PushAsync(new ListaInformacaoPage());
		}

		private async void BtnEconomia(object sender, EventArgs args)
		{
			btnEconomiaClicked = true;
			await Navigation.PushAsync(new ListaInformacaoPage());
		}

		private async void BtnMundo(object sender, EventArgs args)
		{
			btnMundoClicked = true;
			await Navigation.PushAsync(new ListaInformacaoPage());
		}

		private async void BtnTecnologia(object sender, EventArgs args)
		{
			btnTecnologiaClicked = true;
			await Navigation.PushAsync(new ListaInformacaoPage());
		}

		async void BtnInfo(object sender, EventArgs e)
		{
			await Navigation.PushAsync(new AtualizarInformacoesPage());
		}

		async void BtnChamarAPI(object sender, EventArgs e)
		{
			await Navigation.PushAsync(new ApiPage());
		}
	}
}