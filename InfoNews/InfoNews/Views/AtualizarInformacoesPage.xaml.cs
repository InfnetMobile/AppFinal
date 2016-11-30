using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace InfoNews
{
	public partial class AtualizarInformacoesPage : ContentPage
	{
		public AtualizarInformacoesPage()
		{
			InitializeComponent();

			this.Title = "Minhas Informações";

			//this.id.Text = App.Database.GetUsuario(App.IdUsuarioLogado).ID;
			this.nm_nome.Text = App.Database.GetUsuario(App.IdUsuarioLogado).Nm_Nome;
			this.nm_usuario.Text = App.Database.GetUsuario(App.IdUsuarioLogado).Nm_Usuario;
			this.nm_senha.Text = App.Database.GetUsuario(App.IdUsuarioLogado).Nm_Senha;
			this.nm_email.Text = App.Database.GetUsuario(App.IdUsuarioLogado).Nm_Email;


			NavigationPage.SetHasNavigationBar(this, true);
		}

		void saveClicked(object sender, EventArgs e)
		{
			var user = (Usuario)BindingContext;
			App.Database.SalvarUsuario(user);
			this.Navigation.PopAsync();

		}

		void cancelClicked(object sender, EventArgs e)
		{
			var user = (Usuario)BindingContext;
			this.Navigation.PopAsync();
		}

		void deleteClicked(object sender, EventArgs e)
		{
			var todoItem = (Usuario)BindingContext;
			App.Database.DeleteItem(todoItem.ID);
			this.Navigation.PopAsync();
		}
	}
}
