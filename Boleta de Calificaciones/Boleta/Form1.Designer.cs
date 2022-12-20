
namespace Boleta
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtC = new System.Windows.Forms.TextBox();
            this.txtEstudiante = new System.Windows.Forms.TextBox();
            this.txtMatemáticas = new System.Windows.Forms.TextBox();
            this.txtIdiomaE = new System.Windows.Forms.TextBox();
            this.txtCSociales = new System.Windows.Forms.TextBox();
            this.txtCNaturales = new System.Windows.Forms.TextBox();
            this.dtgBoleta = new System.Windows.Forms.DataGridView();
            this.btnLimpiar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgBoleta)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(104, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "C.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(104, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Estudiante";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(104, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Matemáticas";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(104, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "IdiomaE";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(104, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "CSociales";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(104, 177);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "CNaturales";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(201, 230);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 6;
            this.btnAgregar.Text = "Guardar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtC
            // 
            this.txtC.Location = new System.Drawing.Point(183, 24);
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(45, 23);
            this.txtC.TabIndex = 7;
            // 
            // txtEstudiante
            // 
            this.txtEstudiante.Location = new System.Drawing.Point(183, 53);
            this.txtEstudiante.Name = "txtEstudiante";
            this.txtEstudiante.Size = new System.Drawing.Size(228, 23);
            this.txtEstudiante.TabIndex = 8;
            // 
            // txtMatemáticas
            // 
            this.txtMatemáticas.Location = new System.Drawing.Point(183, 84);
            this.txtMatemáticas.Name = "txtMatemáticas";
            this.txtMatemáticas.Size = new System.Drawing.Size(45, 23);
            this.txtMatemáticas.TabIndex = 9;
            // 
            // txtIdiomaE
            // 
            this.txtIdiomaE.Location = new System.Drawing.Point(183, 112);
            this.txtIdiomaE.Name = "txtIdiomaE";
            this.txtIdiomaE.Size = new System.Drawing.Size(45, 23);
            this.txtIdiomaE.TabIndex = 10;
            // 
            // txtCSociales
            // 
            this.txtCSociales.Location = new System.Drawing.Point(183, 141);
            this.txtCSociales.Name = "txtCSociales";
            this.txtCSociales.Size = new System.Drawing.Size(45, 23);
            this.txtCSociales.TabIndex = 11;
            // 
            // txtCNaturales
            // 
            this.txtCNaturales.Location = new System.Drawing.Point(183, 173);
            this.txtCNaturales.Name = "txtCNaturales";
            this.txtCNaturales.Size = new System.Drawing.Size(45, 23);
            this.txtCNaturales.TabIndex = 12;
            // 
            // dtgBoleta
            // 
            this.dtgBoleta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgBoleta.Location = new System.Drawing.Point(104, 259);
            this.dtgBoleta.Name = "dtgBoleta";
            this.dtgBoleta.RowTemplate.Height = 25;
            this.dtgBoleta.Size = new System.Drawing.Size(550, 179);
            this.dtgBoleta.TabIndex = 13;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(335, 230);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 14;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.dtgBoleta);
            this.Controls.Add(this.txtCNaturales);
            this.Controls.Add(this.txtCSociales);
            this.Controls.Add(this.txtIdiomaE);
            this.Controls.Add(this.txtMatemáticas);
            this.Controls.Add(this.txtEstudiante);
            this.Controls.Add(this.txtC);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dtgBoleta)).EndInit();
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
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtC;
        private System.Windows.Forms.TextBox txtEstudiante;
        private System.Windows.Forms.TextBox txtMatemáticas;
        private System.Windows.Forms.TextBox txtIdiomaE;
        private System.Windows.Forms.TextBox txtCSociales;
        private System.Windows.Forms.TextBox txtCNaturales;
        private System.Windows.Forms.DataGridView dtgBoleta;
        private System.Windows.Forms.Button btnLimpiar;
    }
}

