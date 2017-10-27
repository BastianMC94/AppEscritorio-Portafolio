namespace GUI
{
	partial class Programa
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.metroLabelApellidos = new MetroFramework.Controls.MetroLabel();
			this.metroLabelRUT = new MetroFramework.Controls.MetroLabel();
			this.metroLabelNombre1 = new MetroFramework.Controls.MetroLabel();
			this.txtNombrePrograma = new MetroFramework.Controls.MetroTextBox();
			this.txtPaisDestino = new MetroFramework.Controls.MetroTextBox();
			this.txtDescripcion = new MetroFramework.Controls.MetroTextBox();
			this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
			this.txtCupos = new MetroFramework.Controls.MetroTextBox();
			this.dateTimeFechaInicio = new MetroFramework.Controls.MetroDateTime();
			this.metroLabelFecha = new MetroFramework.Controls.MetroLabel();
			this.dateTimeFechaTermino = new MetroFramework.Controls.MetroDateTime();
			this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
			this.btnCrear = new MetroFramework.Controls.MetroTile();
			this.SuspendLayout();
			// 
			// metroLabelApellidos
			// 
			this.metroLabelApellidos.Location = new System.Drawing.Point(108, 149);
			this.metroLabelApellidos.Name = "metroLabelApellidos";
			this.metroLabelApellidos.Size = new System.Drawing.Size(81, 29);
			this.metroLabelApellidos.TabIndex = 12;
			this.metroLabelApellidos.Text = "País Destino";
			this.metroLabelApellidos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// metroLabelRUT
			// 
			this.metroLabelRUT.Location = new System.Drawing.Point(23, 79);
			this.metroLabelRUT.Name = "metroLabelRUT";
			this.metroLabelRUT.Size = new System.Drawing.Size(166, 29);
			this.metroLabelRUT.TabIndex = 7;
			this.metroLabelRUT.Text = "Nombre del Programa";
			this.metroLabelRUT.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// metroLabelNombre1
			// 
			this.metroLabelNombre1.Location = new System.Drawing.Point(108, 114);
			this.metroLabelNombre1.Name = "metroLabelNombre1";
			this.metroLabelNombre1.Size = new System.Drawing.Size(81, 29);
			this.metroLabelNombre1.TabIndex = 11;
			this.metroLabelNombre1.Text = "Descripción";
			this.metroLabelNombre1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtNombrePrograma
			// 
			// 
			// 
			// 
			this.txtNombrePrograma.CustomButton.Image = null;
			this.txtNombrePrograma.CustomButton.Location = new System.Drawing.Point(263, 1);
			this.txtNombrePrograma.CustomButton.Name = "";
			this.txtNombrePrograma.CustomButton.Size = new System.Drawing.Size(27, 27);
			this.txtNombrePrograma.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.txtNombrePrograma.CustomButton.TabIndex = 1;
			this.txtNombrePrograma.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.txtNombrePrograma.CustomButton.UseSelectable = true;
			this.txtNombrePrograma.CustomButton.Visible = false;
			this.txtNombrePrograma.FontSize = MetroFramework.MetroTextBoxSize.Medium;
			this.txtNombrePrograma.Lines = new string[0];
			this.txtNombrePrograma.Location = new System.Drawing.Point(195, 79);
			this.txtNombrePrograma.MaxLength = 12;
			this.txtNombrePrograma.Name = "txtNombrePrograma";
			this.txtNombrePrograma.PasswordChar = '\0';
			this.txtNombrePrograma.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.txtNombrePrograma.SelectedText = "";
			this.txtNombrePrograma.SelectionLength = 0;
			this.txtNombrePrograma.SelectionStart = 0;
			this.txtNombrePrograma.ShortcutsEnabled = true;
			this.txtNombrePrograma.Size = new System.Drawing.Size(291, 29);
			this.txtNombrePrograma.TabIndex = 8;
			this.txtNombrePrograma.UseCustomForeColor = true;
			this.txtNombrePrograma.UseSelectable = true;
			this.txtNombrePrograma.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.txtNombrePrograma.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
			// 
			// txtPaisDestino
			// 
			// 
			// 
			// 
			this.txtPaisDestino.CustomButton.Image = null;
			this.txtPaisDestino.CustomButton.Location = new System.Drawing.Point(263, 1);
			this.txtPaisDestino.CustomButton.Name = "";
			this.txtPaisDestino.CustomButton.Size = new System.Drawing.Size(27, 27);
			this.txtPaisDestino.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.txtPaisDestino.CustomButton.TabIndex = 1;
			this.txtPaisDestino.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.txtPaisDestino.CustomButton.UseSelectable = true;
			this.txtPaisDestino.CustomButton.Visible = false;
			this.txtPaisDestino.FontSize = MetroFramework.MetroTextBoxSize.Medium;
			this.txtPaisDestino.Lines = new string[0];
			this.txtPaisDestino.Location = new System.Drawing.Point(195, 149);
			this.txtPaisDestino.MaxLength = 40;
			this.txtPaisDestino.Name = "txtPaisDestino";
			this.txtPaisDestino.PasswordChar = '\0';
			this.txtPaisDestino.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.txtPaisDestino.SelectedText = "";
			this.txtPaisDestino.SelectionLength = 0;
			this.txtPaisDestino.SelectionStart = 0;
			this.txtPaisDestino.ShortcutsEnabled = true;
			this.txtPaisDestino.Size = new System.Drawing.Size(291, 29);
			this.txtPaisDestino.TabIndex = 10;
			this.txtPaisDestino.UseCustomForeColor = true;
			this.txtPaisDestino.UseSelectable = true;
			this.txtPaisDestino.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.txtPaisDestino.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
			// 
			// txtDescripcion
			// 
			// 
			// 
			// 
			this.txtDescripcion.CustomButton.Image = null;
			this.txtDescripcion.CustomButton.Location = new System.Drawing.Point(263, 1);
			this.txtDescripcion.CustomButton.Name = "";
			this.txtDescripcion.CustomButton.Size = new System.Drawing.Size(27, 27);
			this.txtDescripcion.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.txtDescripcion.CustomButton.TabIndex = 1;
			this.txtDescripcion.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.txtDescripcion.CustomButton.UseSelectable = true;
			this.txtDescripcion.CustomButton.Visible = false;
			this.txtDescripcion.FontSize = MetroFramework.MetroTextBoxSize.Medium;
			this.txtDescripcion.Lines = new string[0];
			this.txtDescripcion.Location = new System.Drawing.Point(195, 114);
			this.txtDescripcion.MaxLength = 40;
			this.txtDescripcion.Name = "txtDescripcion";
			this.txtDescripcion.PasswordChar = '\0';
			this.txtDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.txtDescripcion.SelectedText = "";
			this.txtDescripcion.SelectionLength = 0;
			this.txtDescripcion.SelectionStart = 0;
			this.txtDescripcion.ShortcutsEnabled = true;
			this.txtDescripcion.Size = new System.Drawing.Size(291, 29);
			this.txtDescripcion.TabIndex = 9;
			this.txtDescripcion.UseCustomForeColor = true;
			this.txtDescripcion.UseSelectable = true;
			this.txtDescripcion.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.txtDescripcion.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
			// 
			// metroLabel3
			// 
			this.metroLabel3.Location = new System.Drawing.Point(108, 254);
			this.metroLabel3.Name = "metroLabel3";
			this.metroLabel3.Size = new System.Drawing.Size(81, 29);
			this.metroLabel3.TabIndex = 18;
			this.metroLabel3.Text = "Cupos";
			this.metroLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtCupos
			// 
			// 
			// 
			// 
			this.txtCupos.CustomButton.Image = null;
			this.txtCupos.CustomButton.Location = new System.Drawing.Point(43, 1);
			this.txtCupos.CustomButton.Name = "";
			this.txtCupos.CustomButton.Size = new System.Drawing.Size(27, 27);
			this.txtCupos.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.txtCupos.CustomButton.TabIndex = 1;
			this.txtCupos.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.txtCupos.CustomButton.UseSelectable = true;
			this.txtCupos.CustomButton.Visible = false;
			this.txtCupos.FontSize = MetroFramework.MetroTextBoxSize.Medium;
			this.txtCupos.Lines = new string[0];
			this.txtCupos.Location = new System.Drawing.Point(195, 254);
			this.txtCupos.MaxLength = 40;
			this.txtCupos.Name = "txtCupos";
			this.txtCupos.PasswordChar = '\0';
			this.txtCupos.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.txtCupos.SelectedText = "";
			this.txtCupos.SelectionLength = 0;
			this.txtCupos.SelectionStart = 0;
			this.txtCupos.ShortcutsEnabled = true;
			this.txtCupos.Size = new System.Drawing.Size(71, 29);
			this.txtCupos.TabIndex = 17;
			this.txtCupos.UseCustomForeColor = true;
			this.txtCupos.UseSelectable = true;
			this.txtCupos.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.txtCupos.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
			this.txtCupos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCupos_KeyPress);
			// 
			// dateTimeFechaInicio
			// 
			this.dateTimeFechaInicio.CalendarFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
			this.dateTimeFechaInicio.Location = new System.Drawing.Point(195, 184);
			this.dateTimeFechaInicio.MinimumSize = new System.Drawing.Size(0, 29);
			this.dateTimeFechaInicio.Name = "dateTimeFechaInicio";
			this.dateTimeFechaInicio.Size = new System.Drawing.Size(291, 29);
			this.dateTimeFechaInicio.TabIndex = 22;
			this.dateTimeFechaInicio.Value = new System.DateTime(2017, 10, 27, 20, 35, 14, 0);
			// 
			// metroLabelFecha
			// 
			this.metroLabelFecha.Location = new System.Drawing.Point(98, 184);
			this.metroLabelFecha.Name = "metroLabelFecha";
			this.metroLabelFecha.Size = new System.Drawing.Size(91, 29);
			this.metroLabelFecha.TabIndex = 23;
			this.metroLabelFecha.Text = "Fecha Inicio";
			this.metroLabelFecha.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// dateTimeFechaTermino
			// 
			this.dateTimeFechaTermino.CalendarFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
			this.dateTimeFechaTermino.Location = new System.Drawing.Point(195, 219);
			this.dateTimeFechaTermino.MinimumSize = new System.Drawing.Size(0, 29);
			this.dateTimeFechaTermino.Name = "dateTimeFechaTermino";
			this.dateTimeFechaTermino.Size = new System.Drawing.Size(291, 29);
			this.dateTimeFechaTermino.TabIndex = 24;
			// 
			// metroLabel1
			// 
			this.metroLabel1.Location = new System.Drawing.Point(81, 219);
			this.metroLabel1.Name = "metroLabel1";
			this.metroLabel1.Size = new System.Drawing.Size(108, 29);
			this.metroLabel1.TabIndex = 25;
			this.metroLabel1.Text = "Fecha Termino";
			this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// btnCrear
			// 
			this.btnCrear.ActiveControl = null;
			this.btnCrear.Location = new System.Drawing.Point(470, 300);
			this.btnCrear.Name = "btnCrear";
			this.btnCrear.Size = new System.Drawing.Size(75, 75);
			this.btnCrear.Style = MetroFramework.MetroColorStyle.White;
			this.btnCrear.TabIndex = 26;
			this.btnCrear.TileImage = global::GUI.Properties.Resources.check_circle_o;
			this.btnCrear.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btnCrear.UseSelectable = true;
			this.btnCrear.UseTileImage = true;
			this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
			// 
			// Programa
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(568, 385);
			this.Controls.Add(this.btnCrear);
			this.Controls.Add(this.dateTimeFechaTermino);
			this.Controls.Add(this.metroLabel1);
			this.Controls.Add(this.dateTimeFechaInicio);
			this.Controls.Add(this.metroLabelFecha);
			this.Controls.Add(this.metroLabel3);
			this.Controls.Add(this.txtCupos);
			this.Controls.Add(this.metroLabelApellidos);
			this.Controls.Add(this.metroLabelRUT);
			this.Controls.Add(this.metroLabelNombre1);
			this.Controls.Add(this.txtNombrePrograma);
			this.Controls.Add(this.txtPaisDestino);
			this.Controls.Add(this.txtDescripcion);
			this.MaximizeBox = false;
			this.Name = "Programa";
			this.Resizable = false;
			this.Text = "Programa";
			this.ResumeLayout(false);

		}

		#endregion

		private MetroFramework.Controls.MetroLabel metroLabelApellidos;
		private MetroFramework.Controls.MetroLabel metroLabelRUT;
		private MetroFramework.Controls.MetroLabel metroLabelNombre1;
		private MetroFramework.Controls.MetroTextBox txtNombrePrograma;
		private MetroFramework.Controls.MetroTextBox txtPaisDestino;
		private MetroFramework.Controls.MetroTextBox txtDescripcion;
		private MetroFramework.Controls.MetroLabel metroLabel3;
		private MetroFramework.Controls.MetroTextBox txtCupos;
		private MetroFramework.Controls.MetroDateTime dateTimeFechaInicio;
		private MetroFramework.Controls.MetroLabel metroLabelFecha;
		private MetroFramework.Controls.MetroDateTime dateTimeFechaTermino;
		private MetroFramework.Controls.MetroLabel metroLabel1;
		private MetroFramework.Controls.MetroTile btnCrear;
	}
}