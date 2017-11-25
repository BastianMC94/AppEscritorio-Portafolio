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
			this.metroTile3 = new MetroFramework.Controls.MetroTile();
			this.metroTile2 = new MetroFramework.Controls.MetroTile();
			this.metroTile1 = new MetroFramework.Controls.MetroTile();
			this.btnCrearPrograma = new MetroFramework.Controls.MetroTile();
			this.SuspendLayout();
			// 
			// metroTile3
			// 
			this.metroTile3.ActiveControl = null;
			this.metroTile3.Location = new System.Drawing.Point(241, 98);
			this.metroTile3.Name = "metroTile3";
			this.metroTile3.Size = new System.Drawing.Size(150, 90);
			this.metroTile3.TabIndex = 4;
			this.metroTile3.Text = "Crear CEL";
			this.metroTile3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.metroTile3.TileImage = global::GUI.Properties.Resources.mortar_board;
			this.metroTile3.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.metroTile3.UseSelectable = true;
			this.metroTile3.UseTileImage = true;
			this.metroTile3.Click += new System.EventHandler(this.metroTile3_Click);
			// 
			// metroTile2
			// 
			this.metroTile2.ActiveControl = null;
			this.metroTile2.Location = new System.Drawing.Point(64, 208);
			this.metroTile2.Name = "metroTile2";
			this.metroTile2.Size = new System.Drawing.Size(150, 90);
			this.metroTile2.TabIndex = 3;
			this.metroTile2.Text = "Lista CEM";
			this.metroTile2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.metroTile2.TileImage = global::GUI.Properties.Resources.list_ol;
			this.metroTile2.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.metroTile2.UseSelectable = true;
			this.metroTile2.UseTileImage = true;
			this.metroTile2.Click += new System.EventHandler(this.metroTile1_Click);
			// 
			// metroTile1
			// 
			this.metroTile1.ActiveControl = null;
			this.metroTile1.Location = new System.Drawing.Point(241, 208);
			this.metroTile1.Name = "metroTile1";
			this.metroTile1.Size = new System.Drawing.Size(150, 90);
			this.metroTile1.TabIndex = 2;
			this.metroTile1.Text = "Lista CEL";
			this.metroTile1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.metroTile1.TileImage = global::GUI.Properties.Resources.list_ol;
			this.metroTile1.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.metroTile1.UseSelectable = true;
			this.metroTile1.UseTileImage = true;
			this.metroTile1.Click += new System.EventHandler(this.metroTile2_Click);
			// 
			// btnCrearPrograma
			// 
			this.btnCrearPrograma.ActiveControl = null;
			this.btnCrearPrograma.Location = new System.Drawing.Point(64, 98);
			this.btnCrearPrograma.Name = "btnCrearPrograma";
			this.btnCrearPrograma.Size = new System.Drawing.Size(150, 90);
			this.btnCrearPrograma.TabIndex = 1;
			this.btnCrearPrograma.Text = "Crear CEM";
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
			this.ClientSize = new System.Drawing.Size(449, 336);
			this.Controls.Add(this.metroTile3);
			this.Controls.Add(this.metroTile2);
			this.Controls.Add(this.metroTile1);
			this.Controls.Add(this.btnCrearPrograma);
			this.MaximizeBox = false;
			this.Name = "Menu";
			this.Resizable = false;
			this.Text = "Menú";
			this.ResumeLayout(false);

		}

		#endregion

		private MetroFramework.Controls.MetroTile btnCrearPrograma;
		private MetroFramework.Controls.MetroTile metroTile1;
		private MetroFramework.Controls.MetroTile metroTile2;
		private MetroFramework.Controls.MetroTile metroTile3;
	}
}