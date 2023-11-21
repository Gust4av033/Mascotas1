namespace Principalfrm
{
    partial class Sistemafrm
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label2 = new System.Windows.Forms.Label();
            this.agregarBtn = new System.Windows.Forms.Button();
            this.salirBtn = new System.Windows.Forms.Button();
            this.tablaListarDtGv = new System.Windows.Forms.DataGridView();
            this.mascotasDataSet = new Principalfrm.MascotasDataSet();
            this.datosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.datosTableAdapter = new Principalfrm.MascotasDataSetTableAdapters.DatosTableAdapter();
            this.nombreMascotaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidoMascotaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.razaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaNacimientoMascotaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroContactoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tablaListarDtGv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mascotasDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(179, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(420, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sistema para inscribir una mascota";
            // 
            // agregarBtn
            // 
            this.agregarBtn.Location = new System.Drawing.Point(746, 88);
            this.agregarBtn.Name = "agregarBtn";
            this.agregarBtn.Size = new System.Drawing.Size(180, 40);
            this.agregarBtn.TabIndex = 2;
            this.agregarBtn.Text = "Agregar";
            this.agregarBtn.UseVisualStyleBackColor = true;
            this.agregarBtn.Click += new System.EventHandler(this.agregarBtn_Click);
            // 
            // salirBtn
            // 
            this.salirBtn.Location = new System.Drawing.Point(746, 367);
            this.salirBtn.Name = "salirBtn";
            this.salirBtn.Size = new System.Drawing.Size(180, 40);
            this.salirBtn.TabIndex = 3;
            this.salirBtn.Text = "Salir";
            this.salirBtn.UseVisualStyleBackColor = true;
            this.salirBtn.Click += new System.EventHandler(this.salirBtn_Click);
            // 
            // tablaListarDtGv
            // 
            this.tablaListarDtGv.AllowUserToAddRows = false;
            this.tablaListarDtGv.AllowUserToDeleteRows = false;
            this.tablaListarDtGv.AllowUserToOrderColumns = true;
            this.tablaListarDtGv.AutoGenerateColumns = false;
            this.tablaListarDtGv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaListarDtGv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombreMascotaDataGridViewTextBoxColumn,
            this.apellidoMascotaDataGridViewTextBoxColumn,
            this.razaDataGridViewTextBoxColumn,
            this.fechaNacimientoMascotaDataGridViewTextBoxColumn,
            this.numeroContactoDataGridViewTextBoxColumn});
            this.tablaListarDtGv.DataSource = this.datosBindingSource;
            this.tablaListarDtGv.Location = new System.Drawing.Point(13, 88);
            this.tablaListarDtGv.Name = "tablaListarDtGv";
            this.tablaListarDtGv.ReadOnly = true;
            this.tablaListarDtGv.RowHeadersWidth = 51;
            this.tablaListarDtGv.RowTemplate.Height = 24;
            this.tablaListarDtGv.Size = new System.Drawing.Size(686, 319);
            this.tablaListarDtGv.TabIndex = 4;
            this.tablaListarDtGv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablaListarDtGv_CellContentClick);
            // 
            // mascotasDataSet
            // 
            this.mascotasDataSet.DataSetName = "MascotasDataSet";
            this.mascotasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // datosBindingSource
            // 
            this.datosBindingSource.DataMember = "Datos";
            this.datosBindingSource.DataSource = this.mascotasDataSet;
            // 
            // datosTableAdapter
            // 
            this.datosTableAdapter.ClearBeforeFill = true;
            // 
            // nombreMascotaDataGridViewTextBoxColumn
            // 
            this.nombreMascotaDataGridViewTextBoxColumn.DataPropertyName = "NombreMascota";
            this.nombreMascotaDataGridViewTextBoxColumn.HeaderText = "NombreMascota";
            this.nombreMascotaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nombreMascotaDataGridViewTextBoxColumn.Name = "nombreMascotaDataGridViewTextBoxColumn";
            this.nombreMascotaDataGridViewTextBoxColumn.ReadOnly = true;
            this.nombreMascotaDataGridViewTextBoxColumn.Width = 125;
            // 
            // apellidoMascotaDataGridViewTextBoxColumn
            // 
            this.apellidoMascotaDataGridViewTextBoxColumn.DataPropertyName = "ApellidoMascota";
            this.apellidoMascotaDataGridViewTextBoxColumn.HeaderText = "ApellidoMascota";
            this.apellidoMascotaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.apellidoMascotaDataGridViewTextBoxColumn.Name = "apellidoMascotaDataGridViewTextBoxColumn";
            this.apellidoMascotaDataGridViewTextBoxColumn.ReadOnly = true;
            this.apellidoMascotaDataGridViewTextBoxColumn.Width = 125;
            // 
            // razaDataGridViewTextBoxColumn
            // 
            this.razaDataGridViewTextBoxColumn.DataPropertyName = "Raza";
            this.razaDataGridViewTextBoxColumn.HeaderText = "Raza";
            this.razaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.razaDataGridViewTextBoxColumn.Name = "razaDataGridViewTextBoxColumn";
            this.razaDataGridViewTextBoxColumn.ReadOnly = true;
            this.razaDataGridViewTextBoxColumn.Width = 125;
            // 
            // fechaNacimientoMascotaDataGridViewTextBoxColumn
            // 
            this.fechaNacimientoMascotaDataGridViewTextBoxColumn.DataPropertyName = "FechaNacimientoMascota";
            this.fechaNacimientoMascotaDataGridViewTextBoxColumn.HeaderText = "FechaNacimientoMascota";
            this.fechaNacimientoMascotaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fechaNacimientoMascotaDataGridViewTextBoxColumn.Name = "fechaNacimientoMascotaDataGridViewTextBoxColumn";
            this.fechaNacimientoMascotaDataGridViewTextBoxColumn.ReadOnly = true;
            this.fechaNacimientoMascotaDataGridViewTextBoxColumn.Width = 125;
            // 
            // numeroContactoDataGridViewTextBoxColumn
            // 
            this.numeroContactoDataGridViewTextBoxColumn.DataPropertyName = "NumeroContacto";
            this.numeroContactoDataGridViewTextBoxColumn.HeaderText = "NumeroContacto";
            this.numeroContactoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.numeroContactoDataGridViewTextBoxColumn.Name = "numeroContactoDataGridViewTextBoxColumn";
            this.numeroContactoDataGridViewTextBoxColumn.ReadOnly = true;
            this.numeroContactoDataGridViewTextBoxColumn.Width = 125;
            // 
            // Sistemafrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 494);
            this.Controls.Add(this.tablaListarDtGv);
            this.Controls.Add(this.salirBtn);
            this.Controls.Add(this.agregarBtn);
            this.Controls.Add(this.label2);
            this.Name = "Sistemafrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Sistema";
            this.Load += new System.EventHandler(this.Sistemafrm_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.tablaListarDtGv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mascotasDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button agregarBtn;
        private System.Windows.Forms.Button salirBtn;
        private System.Windows.Forms.DataGridView tablaListarDtGv;
        private MascotasDataSet mascotasDataSet;
        private System.Windows.Forms.BindingSource datosBindingSource;
        private MascotasDataSetTableAdapters.DatosTableAdapter datosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreMascotaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidoMascotaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn razaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaNacimientoMascotaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroContactoDataGridViewTextBoxColumn;
    }
}

