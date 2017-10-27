namespace GUI
{
	partial class Menu
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
			this.btnCrearPrograma = new MetroFramework.Controls.MetroTile();
			this.SuspendLayout();
			// 
			// btnCrearPrograma
			// 
			this.btnCrearPrograma.ActiveControl = null;
			this.btnCrearPrograma.Location = new System.Drawing.Point(64, 98);
			this.btnCrearPrograma.Name = "btnCrearPrograma";
			this.btnCrearPrograma.Size = new System.Drawing.Size(150, 90);
			this.btnCrearPrograma.TabIndex = 1;
			this.btnCrearPrograma.Text = "Crear Programa";
			this.btnCrearPrograma.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnCrearPrograma.TileImage = global::GUI.Properties.Resources.university;
			this.btnCrearPrograma.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btnCrearPrograma.UseSelectable = true;
			this.btnCrearPrograma.UseTileImage = true;
			this.btnCrearPrograma.Click += new System.EventHandler(this.btnCrearPrograma_Click);
			// 
			// Menu
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 261);
			this.Controls.Add(this.btnCrearPrograma);
			this.MaximizeBox = false;
			this.Name = "Menu";
			this.Resizable = false;
			this.Text = "Menú CEM";
			this.Load += new System.EventHandler(this.Menu_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private MetroFramework.Controls.MetroTile btnCrearPrograma;
	}
}