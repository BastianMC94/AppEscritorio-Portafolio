using MetroFramework;
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
	public partial class Programa : MetroForm
	{
		public Programa()
		{
			InitializeComponent();
		}

		private void txtCupos_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
			{
				MetroMessageBox.Show(this, "Solo se permiten números.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
				e.Handled = true;
				return;
			}
		}

		private void btnCrear_Click(object sender, EventArgs e)
		{
			//Validaciones
			int count = 0;
			if (txtNombrePrograma.Text.Equals(""))
			{
				MetroMessageBox.Show(this, "Nombre del programa no válido.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
				count++;
				return;
			}
			if (txtDescripcion.Text.Equals("") & txtDescripcion.Text.Equals(""))
			{
				MetroMessageBox.Show(this, "Descripción no válida.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
				count++;
				return;
			}
			if (txtPaisDestino.Text.Equals("") & txtPaisDestino.Text.Equals(""))
			{
				MetroMessageBox.Show(this, "País de destino no válido.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
				count++;
				return;
			}





			//Preguntar antes de ingresar
			if (MetroMessageBox.Show(this, "¿Está seguro de que desea ingresar El siguiente curso?\nNombre del Curso: " + txtNombrePrograma.Text + "\nDescripción: " + txtDescripcion.Text + "\nN° País Destino: " + txtPaisDestino.Text + "\nFecha de Inicio: " + dateTimeFechaInicio.Value + "\nFecha de Termino: " + dateTimeFechaTermino.Value + "\nCupos: " + Convert.ToSingle(txtCupos.Text), "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
			{




			}

		}
	}
}
