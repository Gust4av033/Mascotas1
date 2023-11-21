namespace Principalfrm
{
    partial class AgregarMascfrm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.nombreTxt = new System.Windows.Forms.TextBox();
            this.apellidoTxt = new System.Windows.Forms.TextBox();
            this.razaTxt = new System.Windows.Forms.TextBox();
            this.contactoTxt = new System.Windows.Forms.TextBox();
            this.fechaDte = new System.Windows.Forms.DateTimePicker();
            this.guardarBtn = new System.Windows.Forms.Button();
            this.salirBtnAM = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(141, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(290, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Agregar mascota";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre (mascota)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Apellido (mascota)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Raza";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 293);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Contacto";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 354);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Fecha de nacimiento";
            // 
            // nombreTxt
            // 
            this.nombreTxt.Location = new System.Drawing.Point(235, 106);
            this.nombreTxt.Name = "nombreTxt";
            this.nombreTxt.Size = new System.Drawing.Size(196, 22);
            this.nombreTxt.TabIndex = 6;
            // 
            // apellidoTxt
            // 
            this.apellidoTxt.Location = new System.Drawing.Point(235, 157);
            this.apellidoTxt.Name = "apellidoTxt";
            this.apellidoTxt.Size = new System.Drawing.Size(196, 22);
            this.apellidoTxt.TabIndex = 7;
            // 
            // razaTxt
            // 
            this.razaTxt.Location = new System.Drawing.Point(235, 222);
            this.razaTxt.Name = "razaTxt";
            this.razaTxt.Size = new System.Drawing.Size(196, 22);
            this.razaTxt.TabIndex = 8;
            // 
            // contactoTxt
            // 
            this.contactoTxt.Location = new System.Drawing.Point(235, 286);
            this.contactoTxt.Name = "contactoTxt";
            this.contactoTxt.Size = new System.Drawing.Size(196, 22);
            this.contactoTxt.TabIndex = 9;
            // 
            // fechaDte
            // 
            this.fechaDte.Location = new System.Drawing.Point(231, 349);
            this.fechaDte.Name = "fechaDte";
            this.fechaDte.Size = new System.Drawing.Size(200, 22);
            this.fechaDte.TabIndex = 10;
            // 
            // guardarBtn
            // 
            this.guardarBtn.Location = new System.Drawing.Point(330, 450);
            this.guardarBtn.Name = "guardarBtn";
            this.guardarBtn.Size = new System.Drawing.Size(101, 30);
            this.guardarBtn.TabIndex = 11;
            this.guardarBtn.Text = "Guardar";
            this.guardarBtn.UseVisualStyleBackColor = true;
            this.guardarBtn.Click += new System.EventHandler(this.guardarBtn_Click);
            // 
            // salirBtnAM
            // 
            this.salirBtnAM.Location = new System.Drawing.Point(22, 450);
            this.salirBtnAM.Name = "salirBtnAM";
            this.salirBtnAM.Size = new System.Drawing.Size(75, 30);
            this.salirBtnAM.TabIndex = 12;
            this.salirBtnAM.Text = "Salir";
            this.salirBtnAM.UseVisualStyleBackColor = true;
            this.salirBtnAM.Click += new System.EventHandler(this.salirBtnAM_Click);
            // 
            // AgregarMascfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 585);
            this.Controls.Add(this.salirBtnAM);
            this.Controls.Add(this.guardarBtn);
            this.Controls.Add(this.fechaDte);
            this.Controls.Add(this.contactoTxt);
            this.Controls.Add(this.razaTxt);
            this.Controls.Add(this.apellidoTxt);
            this.Controls.Add(this.nombreTxt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AgregarMascfrm";
            this.Text = "AgregarMascfrm";
            this.Load += new System.EventHandler(this.AgregarMascfrm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox nombreTxt;
        private System.Windows.Forms.TextBox apellidoTxt;
        private System.Windows.Forms.TextBox razaTxt;
        private System.Windows.Forms.TextBox contactoTxt;
        private System.Windows.Forms.DateTimePicker fechaDte;
        private System.Windows.Forms.Button guardarBtn;
        private System.Windows.Forms.Button salirBtnAM;
    }
}