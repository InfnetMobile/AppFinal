using System;
using Xamarin.Forms;

namespace InfoNews
{
	public class LoginPageCS : ContentPage
	{
		Entry nm_usuario, nm_senha;

		public LoginPageCS()
		{
			var toolbarItem = new ToolbarItem
			{
				Text = "Cadastre-se"
			};
			toolbarItem.Clicked += BotaoEntrar;
			ToolbarItems.Add(toolbarItem);

			nm_usuario = new Entry
			{
				Placeholder = "usuário"
			};
			nm_senha = new Entry
			{
				IsPassword = true
			};
			var loginButton = new Button
			{
				Text = "Entrar"
			};
			loginButton.Clicked += BotaoEntrar;

			Content = new StackLayout
			{
				VerticalOptions = LayoutOptions.StartAndExpand,
				Children = {
					new Label { Text = "Usuário" },
					nm_usuario,
					new Label { Text = "Senha" },
					nm_senha,
					loginButton
				}
			};
		}

		async void BotaoCadastro(object sender, EventArgs e)
		{
			await Navigation.PushAsync(new CadastroPageCS());
		}

		async void BotaoEntrar(object sender, EventArgs e)
		{
			var usuario = new Usuario
			{
				Nm_Usuario = nm_usuario.Text,
				Nm_Senha = nm_senha.Text
			};

			if (string.IsNullOrEmpty(nm_usuario.Text) || string.IsNullOrEmpty(nm_senha.Text))
			{
				await DisplayAlert("Erro", "Informe o usuário e senha", "OK");
				nm_senha.Text = string.Empty;
			}
			else
			{
				var ValidacaoOk = CredencialUsuarioOK(usuario);
				if (ValidacaoOk)
				{
					App.UsuarioLogado = true;
					Navigation.InsertPageBefore(new InfoNewsPage(), this);
					await Navigation.PopAsync();
				}
				else
				{
					await DisplayAlert("Erro", "Falha no acesso", "OK");
					nm_senha.Text = string.Empty;
				}
			}
		}

		bool CredencialUsuarioOK(Usuario usuario)
		{
			UsuarioDataBase data = new UsuarioDataBase();
			return data.GetUsuarioLoginSenha(nm_usuario.Text, nm_senha.Text);
		}
	}
}