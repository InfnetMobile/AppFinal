using System;
using SQLite;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;

namespace InfoNews
{
	public class UsuarioDataBase
	{
		static object locker = new object();

		SQLiteConnection database;

		public UsuarioDataBase()
		{
			database = DependencyService.Get<ISQLite>().GetConnection();

			database.CreateTable<Usuario>();
		}

		public IEnumerable<Usuario> GetUsuarios()
		{
			lock (locker)
			{
				return (from i in database.Table<Usuario>() select i).ToList();
			}
		}

		public Usuario GetUsuario(int id)
		{
			lock (locker)
			{
				return database.Table<Usuario>().FirstOrDefault(x => x.ID == id);
			}
		}

		public bool GetUsuarioLoginSenha(string nm_usuario, string nm_senha)
		{
			bool valido = false;

			lock (locker)
			{
				var sql = database.Table<Usuario>().FirstOrDefault(u => u.Nm_Usuario == nm_usuario && u.Nm_Senha == nm_senha);
			
				if (sql != null)
				{
					valido = true;
				}
				else
				{
					valido = false;
				}

				return valido;
			}
		}

		public int SalvarUsuario(Usuario usuario)
		{
			lock (locker)
			{
				if (usuario.ID != 0)
				{
					database.Update(usuario);
					return usuario.ID;
				}
				else {
					return database.Insert(usuario);
				}
			}
		}

		public int DeleteItem(int id)
		{
			lock (locker)
			{
				return database.Delete<Usuario>(id);
			}
		}

		public IEnumerable<Usuario> GetUsuarios2()
		{
			lock (locker)
			{
				return (from i in database.Table<Usuario>().Where(u => u.Nm_Usuario.ToUpper() == "Cassios") select i).ToList();
			}
		}

		public int RetornarIdUsuario(string nm_usuario, string nm_senha)
		{
			lock (locker)
			{
				var sql = database.Table<Usuario>().FirstOrDefault(u => u.Nm_Usuario == nm_usuario && u.Nm_Senha == nm_senha);

				return sql.ID;
			}
		}
	}
}