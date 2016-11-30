using System;
using SQLite;
using System.Threading.Tasks;

namespace InfoNews
{
	public class Usuario
	{
		/*public Usuario()
		{
		}*/

		[PrimaryKey, AutoIncrement]
		public int ID { get; set; }
		public string Nm_Nome { get; set;}
		public string Nm_Usuario { get; set; }
		public string Nm_Senha { get; set; }
		public string Nm_Email { get; set; }


		public Usuario()
		{
			/*this.ID = 0;
			this.Nm_Nome = " ";
			this.Nm_Usuario = " ";
			this.Nm_Senha = " ";
			this.Nm_Email = " ";*/
		}


	}
}