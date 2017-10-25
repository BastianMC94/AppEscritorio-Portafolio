namespace GUI
{
	partial class Login
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
            this.btnIniciarSesion = new MetroFramework.Controls.MetroTile();
            this.lblCorreo = new MetroFramework.Controls.MetroLabel();
            this.lblContraseña = new MetroFramework.Controls.MetroLabel();
            this.txtCorreo = new MetroFramework.Controls.MetroTextBox();
            this.txtContrasena = new MetroFramework.Controls.MetroTextBox();
            this.lblMenasjeError = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // btnIniciarSesion
            // 
            this.btnIniciarSesion.ActiveControl = null;
            this.btnIniciarSesion.BackColor = System.Drawing.Color.White;
            this.btnIniciarSesion.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnIniciarSesion.Location = new System.Drawing.Point(323, 81);
            this.btnIniciarSesion.Name = "btnIniciarSesion";
            this.btnIniciarSesion.Size = new System.Drawing.Size(62, 61);
            this.btnIniciarSesion.TabIndex = 0;
            this.btnIniciarSesion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnIniciarSesion.TileImage = global::GUI.Properties.Resources.angle_double_right;
            this.btnIniciarSesion.UseCustomBackColor = true;
            this.btnIniciarSesion.UseSelectable = true;
            this.btnIniciarSesion.UseTileImage = true;
            this.btnIniciarSesion.Click += new System.EventHandler(this.btnIniciarSesion_Click);
            this.btnIniciarSesion.Enter += new System.EventHandler(this.btnIniciarSesion_Click);
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Location = new System.Drawing.Point(67, 81);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(54, 19);
            this.lblCorreo.TabIndex = 1;
            this.lblCorreo.Text = "Correo:";
            // 
            // lblContraseña
            // 
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.Location = new System.Drawing.Point(43, 123);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(78, 19);
            this.lblContraseña.TabIndex = 2;
            this.lblContraseña.Text = "Contraseña:";
            // 
            // txtCorreo
            // 
            // 
            // 
            // 
            this.txtCorreo.CustomButton.Image = null;
            this.txtCorreo.CustomButton.Location = new System.Drawing.Point(151, 1);
            this.txtCorreo.CustomButton.Name = "";
            this.txtCorreo.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtCorreo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCorreo.CustomButton.TabIndex = 1;
            this.txtCorreo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCorreo.CustomButton.UseSelectable = true;
            this.txtCorreo.CustomButton.Visible = false;
            this.txtCorreo.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtCorreo.Lines = new string[0];
            this.txtCorreo.Location = new System.Drawing.Point(127, 81);
            this.txtCorreo.MaxLength = 32767;
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.PasswordChar = '\0';
            this.txtCorreo.PromptText = "encargado@cem.cl";
            this.txtCorreo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCorreo.SelectedText = "";
            this.txtCorreo.SelectionLength = 0;
            this.txtCorreo.SelectionStart = 0;
            this.txtCorreo.ShortcutsEnabled = true;
            this.txtCorreo.Size = new System.Drawing.Size(173, 23);
            this.txtCorreo.TabIndex = 3;
            this.txtCorreo.UseSelectable = true;
            this.txtCorreo.WaterMark = "encargado@cem.cl";
            this.txtCorreo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCorreo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtContrasena
            // 
            // 
            // 
            // 
            this.txtContrasena.CustomButton.Image = null;
            this.txtContrasena.CustomButton.Location = new System.Drawing.Point(151, 1);
            this.txtContrasena.CustomButton.Name = "";
            this.txtContrasena.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtContrasena.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtContrasena.CustomButton.TabIndex = 1;
            this.txtContrasena.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtContrasena.CustomButton.UseSelectable = true;
            this.txtContrasena.CustomButton.Visible = false;
            this.txtContrasena.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtContrasena.Lines = new string[0];
            this.txtContrasena.Location = new System.Drawing.Point(127, 123);
            this.txtContrasena.MaxLength = 32767;
            this.txtContrasena.Name = "txtContrasena";
            this.txtContrasena.PasswordChar = '*';
            this.txtContrasena.PromptText = "**********";
            this.txtContrasena.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtContrasena.SelectedText = "";
            this.txtContrasena.SelectionLength = 0;
            this.txtContrasena.SelectionStart = 0;
            this.txtContrasena.ShortcutsEnabled = true;
            this.txtContrasena.Size = new System.Drawing.Size(173, 23);
            this.txtContrasena.TabIndex = 4;
            this.txtContrasena.UseSelectable = true;
            this.txtContrasena.WaterMark = "**********";
            this.txtContrasena.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtContrasena.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblMenasjeError
            // 
            this.lblMenasjeError.AutoSize = true;
            this.lblMenasjeError.Location = new System.Drawing.Point(160, 149);
            this.lblMenasjeError.Name = "lblMenasjeError";
            this.lblMenasjeError.Size = new System.Drawing.Size(87, 19);
            this.lblMenasjeError.TabIndex = 5;
            this.lblMenasjeError.Text = "mensajeError";
            this.lblMenasjeError.Visible = false;

            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 183);
            this.Controls.Add(this.lblMenasjeError);
            this.Controls.Add(this.txtContrasena);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.lblContraseña);
            this.Controls.Add(this.lblCorreo);
            this.Controls.Add(this.btnIniciarSesion);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.Resizable = false;
            this.Text = "Inicio de Sesión";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

        #endregion

        private MetroFramework.Controls.MetroTile btnIniciarSesion;
		private MetroFramework.Controls.MetroLabel lblCorreo;
		private MetroFramework.Controls.MetroLabel lblContraseña;
		private MetroFramework.Controls.MetroTextBox txtCorreo;
		private MetroFramework.Controls.MetroTextBox txtContrasena;
        private MetroFramework.Controls.MetroLabel lblMenasjeError;
    }
}