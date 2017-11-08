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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.CEM_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGridMovimientos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
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
            this.dgvCELID,
            this.CEM_ID});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGridMovimientos.DefaultCellStyle = dataGridViewCellStyle2;
            this.metroGridMovimientos.EnableHeadersVisualStyles = false;
            this.metroGridMovimientos.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGridMovimientos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGridMovimientos.Location = new System.Drawing.Point(49, 63);
            this.metroGridMovimientos.Name = "metroGridMovimientos";
            this.metroGridMovimientos.ReadOnly = true;
            this.metroGridMovimientos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGridMovimientos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.metroGridMovimientos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGridMovimientos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGridMovimientos.Size = new System.Drawing.Size(664, 266);
            this.metroGridMovimientos.TabIndex = 22;
            
            // 
            // dgvID
            // 
            this.dgvID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dgvID.HeaderText = "ID";
            this.dgvID.Name = "dgvID";
            this.dgvID.ReadOnly = true;
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
            this.dgvTermino.Width = 71;
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
            // CEM_ID
            // 
            this.CEM_ID.HeaderText = "CEM_ID";
            this.CEM_ID.Name = "CEM_ID";
            this.CEM_ID.ReadOnly = true;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn CEM_ID;
    }
}