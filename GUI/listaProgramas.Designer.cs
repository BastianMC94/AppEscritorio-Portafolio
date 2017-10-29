namespace GUI
{
	partial class listaProgramas
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
			this.metroGridMovimientos = new MetroFramework.Controls.MetroGrid();
			this.dgvID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dgvNombrePrograma = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dgvDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dgvPaisDestino = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dgvInicio = new System.Windows.Forms.DataGridViewButtonColumn();
			this.dgvTermino = new System.Windows.Forms.DataGridViewButtonColumn();
			this.dgvCupos = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dgvProgramaAsig = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dgvCELID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.metroGridMovimientos)).BeginInit();
			this.SuspendLayout();
			// 
			// metroGridMovimientos
			// 
			this.metroGridMovimientos.AllowUserToAddRows = false;
			this.metroGridMovimientos.AllowUserToDeleteRows = false;
			this.metroGridMovimientos.AllowUserToResizeRows = false;
			this.metroGridMovimientos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.metroGridMovimientos.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.metroGridMovimientos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
			this.metroGridMovimientos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
			dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.metroGridMovimientos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
			this.metroGridMovimientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.metroGridMovimientos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvID,
            this.dgvNombrePrograma,
            this.dgvDescripcion,
            this.dgvPaisDestino,
            this.dgvInicio,
            this.dgvTermino,
            this.dgvCupos,
            this.dgvProgramaAsig,
            this.dgvCELID});
			dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
			dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
			dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.metroGridMovimientos.DefaultCellStyle = dataGridViewCellStyle5;
			this.metroGridMovimientos.EnableHeadersVisualStyles = false;
			this.metroGridMovimientos.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.metroGridMovimientos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.metroGridMovimientos.Location = new System.Drawing.Point(23, 63);
			this.metroGridMovimientos.Name = "metroGridMovimientos";
			this.metroGridMovimientos.ReadOnly = true;
			this.metroGridMovimientos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
			dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
			dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.metroGridMovimientos.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
			this.metroGridMovimientos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.metroGridMovimientos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.metroGridMovimientos.Size = new System.Drawing.Size(692, 233);
			this.metroGridMovimientos.TabIndex = 22;
			this.metroGridMovimientos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.metroGridMovimientos_CellContentClick);
			// 
			// dgvID
			// 
			this.dgvID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.dgvID.HeaderText = "ID";
			this.dgvID.Name = "dgvID";
			this.dgvID.ReadOnly = true;
			this.dgvID.Visible = false;
			this.dgvID.Width = 41;
			// 
			// dgvNombrePrograma
			// 
			this.dgvNombrePrograma.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.dgvNombrePrograma.HeaderText = "Nombre del Programa";
			this.dgvNombrePrograma.Name = "dgvNombrePrograma";
			this.dgvNombrePrograma.ReadOnly = true;
			this.dgvNombrePrograma.Width = 130;
			// 
			// dgvDescripcion
			// 
			this.dgvDescripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.dgvDescripcion.HeaderText = "Descripción";
			this.dgvDescripcion.Name = "dgvDescripcion";
			this.dgvDescripcion.ReadOnly = true;
			this.dgvDescripcion.Width = 90;
			// 
			// dgvPaisDestino
			// 
			this.dgvPaisDestino.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.dgvPaisDestino.HeaderText = "País Destino";
			this.dgvPaisDestino.Name = "dgvPaisDestino";
			this.dgvPaisDestino.ReadOnly = true;
			this.dgvPaisDestino.Width = 85;
			// 
			// dgvInicio
			// 
			this.dgvInicio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.dgvInicio.HeaderText = "Inicio";
			this.dgvInicio.Name = "dgvInicio";
			this.dgvInicio.ReadOnly = true;
			this.dgvInicio.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvInicio.Width = 39;
			// 
			// dgvTermino
			// 
			this.dgvTermino.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.dgvTermino.HeaderText = "Término";
			this.dgvTermino.Name = "dgvTermino";
			this.dgvTermino.ReadOnly = true;
			this.dgvTermino.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvTermino.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			this.dgvTermino.Width = 70;
			// 
			// dgvCupos
			// 
			this.dgvCupos.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.dgvCupos.HeaderText = "Cupos";
			this.dgvCupos.Name = "dgvCupos";
			this.dgvCupos.ReadOnly = true;
			this.dgvCupos.Width = 63;
			// 
			// dgvProgramaAsig
			// 
			this.dgvProgramaAsig.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.dgvProgramaAsig.HeaderText = "Prog. Asignado";
			this.dgvProgramaAsig.Name = "dgvProgramaAsig";
			this.dgvProgramaAsig.ReadOnly = true;
			// 
			// dgvCELID
			// 
			this.dgvCELID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.dgvCELID.HeaderText = "CEL_ID";
			this.dgvCELID.Name = "dgvCELID";
			this.dgvCELID.ReadOnly = true;
			this.dgvCELID.Width = 64;
			// 
			// listaProgramas
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(764, 366);
			this.Controls.Add(this.metroGridMovimientos);
			this.MaximizeBox = false;
			this.Name = "listaProgramas";
			this.Resizable = false;
			this.Text = "lista de Programas";
			((System.ComponentModel.ISupportInitialize)(this.metroGridMovimientos)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private MetroFramework.Controls.MetroGrid metroGridMovimientos;
		private System.Windows.Forms.DataGridViewTextBoxColumn dgvID;
		private System.Windows.Forms.DataGridViewTextBoxColumn dgvNombrePrograma;
		private System.Windows.Forms.DataGridViewTextBoxColumn dgvDescripcion;
		private System.Windows.Forms.DataGridViewTextBoxColumn dgvPaisDestino;
		private System.Windows.Forms.DataGridViewButtonColumn dgvInicio;
		private System.Windows.Forms.DataGridViewButtonColumn dgvTermino;
		private System.Windows.Forms.DataGridViewTextBoxColumn dgvCupos;
		private System.Windows.Forms.DataGridViewTextBoxColumn dgvProgramaAsig;
		private System.Windows.Forms.DataGridViewTextBoxColumn dgvCELID;
	}
}