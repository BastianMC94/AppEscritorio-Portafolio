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
			crearCEM winCrearCEM = new crearCEM();
			winCrearCEM.ShowDialog();
		}

		private void metroTile1_Click(object sender, EventArgs e)
		{
			listaCEM winListaCEM = new listaCEM();
			winListaCEM.ShowDialog();
		}

		private void metroTile2_Click(object sender, EventArgs e)
		{
			listaCEL winListaCEL = new listaCEL();
			winListaCEL.ShowDialog();
		}

		private void metroTile3_Click(object sender, EventArgs e)
		{

		}
	}
}
