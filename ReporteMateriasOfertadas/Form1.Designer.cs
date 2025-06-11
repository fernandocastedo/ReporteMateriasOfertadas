namespace ReporteMateriasOfertadas
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.txtCodCarrera = new System.Windows.Forms.TextBox();
            this.txtCodPlanEstudio = new System.Windows.Forms.TextBox();
            this.txtAnio = new System.Windows.Forms.TextBox();
            this.txtSemestre = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(223, 228);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(315, 52);
            this.button1.TabIndex = 1;
            this.button1.Text = "Abrir Reporte de Materias Ofertadas";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtCodCarrera
            // 
            this.txtCodCarrera.Location = new System.Drawing.Point(67, 68);
            this.txtCodCarrera.Name = "txtCodCarrera";
            this.txtCodCarrera.Size = new System.Drawing.Size(226, 22);
            this.txtCodCarrera.TabIndex = 2;
            // 
            // txtCodPlanEstudio
            // 
            this.txtCodPlanEstudio.Location = new System.Drawing.Point(67, 146);
            this.txtCodPlanEstudio.Name = "txtCodPlanEstudio";
            this.txtCodPlanEstudio.Size = new System.Drawing.Size(226, 22);
            this.txtCodPlanEstudio.TabIndex = 3;
            // 
            // txtAnio
            // 
            this.txtAnio.Location = new System.Drawing.Point(524, 82);
            this.txtAnio.Name = "txtAnio";
            this.txtAnio.Size = new System.Drawing.Size(203, 22);
            this.txtAnio.TabIndex = 4;
            // 
            // txtSemestre
            // 
            this.txtSemestre.Location = new System.Drawing.Point(524, 146);
            this.txtSemestre.Name = "txtSemestre";
            this.txtSemestre.Size = new System.Drawing.Size(203, 22);
            this.txtSemestre.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtSemestre);
            this.Controls.Add(this.txtAnio);
            this.Controls.Add(this.txtCodPlanEstudio);
            this.Controls.Add(this.txtCodCarrera);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtCodCarrera;
        private System.Windows.Forms.TextBox txtCodPlanEstudio;
        private System.Windows.Forms.TextBox txtAnio;
        private System.Windows.Forms.TextBox txtSemestre;
    }
}

