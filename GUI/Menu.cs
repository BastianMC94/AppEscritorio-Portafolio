using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace GUI
{
	public partial class Menu : MetroForm
	{
		public Menu()
		{
			InitializeComponent();
		}

		private void btnCrearPrograma_Click(object sender, EventArgs e)
		{
			Programa winPrograma = new Programa();
			winPrograma.ShowDialog();
		}

		private void metroTile1_Click(object sender, EventArgs e)
		{
			listaProgramas winListaPrograma = new listaProgramas();
			winListaPrograma.ShowDialog();
		}
	}
}
