using System;
using System.Linq;
using Xamarin.Forms;

namespace InfoNews
{
	public class CadastroPageCS : ContentPage
	{
		Entry nm_login, nm_senha, nm_email;

		public CadastroPageCS()
		{
			nm_login = new Entry
			{
				Placeholder = "usuário"
			};
			nm_senha = new Entry
			{
				IsPassword = true
			};
			nm_email = new Entry();
			var signUpButton = new Button
			{
				Text = "Cadastre-se"
			};
			signUpButton.Clicked += BotaoCadastro;

			Title = "Cadastro";
			Content = new StackLayout
			{
				VerticalOptions = LayoutOptions.StartAndExpand,
				Children = {
					new Label { Text = "Usuário" },
					nm_login,
					new Label { Text = "Senha" },
					nm_senha,
					new Label { Text = "E-mail" },
					nm_email,
					signUpButton
				}
			};
		}

		async void BotaoCadastro(object sender, EventArgs e)
		{
			var usuario = new Usuario()
			{
				Nm_Usuario = nm_login.Text,
				Nm_Senha = nm_senha.Text,
				Nm_Email = nm_email.Text
			};

			var sucessoCadastro = CredencialUsuarioOK(usuario);
			if (sucessoCadastro)
			{
				var paginaPrincipal = Navigation.NavigationStack.FirstOrDefault();
				if (paginaPrincipal != null)
				{
					App.UsuarioLogado = true;
					Navigation.InsertPageBefore(new InfoNewsPage(), Navigation.NavigationStack.First());
					await Navigation.PopToRootAsync();
				}
			}
			else 
			{
				await DisplayAlert("Erro","Falha no cadastro","OK");
			}
		}

		bool CredencialUsuarioOK(Usuario usuario)
		{
			return (!string.IsNullOrWhiteSpace(usuario.Nm_Usuario) && !string.IsNullOrWhiteSpace(usuario.Nm_Senha) && !string.IsNullOrWhiteSpace(usuario.Nm_Email) && usuario.Nm_Email.Contains("@"));
		}
	}
}