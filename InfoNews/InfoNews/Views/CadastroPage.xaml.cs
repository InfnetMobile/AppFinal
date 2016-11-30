using System;
using System.Linq;
using Xamarin.Forms;

namespace InfoNews
{
	public partial class CadastroPage : ContentPage
	{
		public CadastroPage()
		{
			InitializeComponent();

			this.Title = "Cadastro";

			NavigationPage.SetHasNavigationBar(this, true);
		}

		async void saveClicked(object sender, EventArgs e)
		{
			var usuario = new Usuario()
			{
				Nm_Nome = nm_nome.Text,
				Nm_Usuario = nm_usuario.Text,
				Nm_Senha = nm_senha.Text,
				Nm_Email = nm_email.Text
			};

			App.Database.SalvarUsuario(usuario);

			var sucessoCadastro = CredencialUsuarioOK(usuario);
			if (sucessoCadastro)
			{
				var paginaPrincipal = Navigation.NavigationStack.FirstOrDefault();
				if (paginaPrincipal != null)
				{
					App.UsuarioLogado = true;
					App.IdUsuarioLogado = App.Database.RetornarIdUsuario(nm_usuario.Text, nm_senha.Text);
					Navigation.InsertPageBefore(new InfoNewsPage(), Navigation.NavigationStack.First());
					await Navigation.PopToRootAsync();
				}
			}
			else
			{
				await DisplayAlert("Erro", "Falha no cadastro", "OK");
			}
		}

		void cancelClicked(object sender, EventArgs e)
		{
			var usuario = (Usuario)BindingContext;
			this.Navigation.PopAsync();
		}

		bool CredencialUsuarioOK(Usuario usuario)
		{
			return (!string.IsNullOrWhiteSpace(usuario.Nm_Usuario) && !string.IsNullOrWhiteSpace(usuario.Nm_Senha) && !string.IsNullOrWhiteSpace(usuario.Nm_Email) && usuario.Nm_Email.Contains("@"));
		}
	}
}
