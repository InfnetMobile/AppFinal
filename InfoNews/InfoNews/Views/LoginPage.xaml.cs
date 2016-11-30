using System;
using Xamarin.Forms;

namespace InfoNews
{
	public partial class LoginPage : ContentPage
	{
		public LoginPage()
		{
			InitializeComponent();

			this.Title = "Info News";
		}

		async void BotaoCadastro(object sender, EventArgs e)
		{
			await Navigation.PushAsync(new CadastroPage());
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
					App.IdUsuarioLogado = App.Database.RetornarIdUsuario(nm_usuario.Text, nm_senha.Text);
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
