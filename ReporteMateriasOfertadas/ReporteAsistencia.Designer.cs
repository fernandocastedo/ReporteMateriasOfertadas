﻿namespace ReporteMateriasOfertadas
{
    partial class ReporteAsistencia
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
            this.txtCodMateria = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(270, 179);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(275, 66);
            this.button1.TabIndex = 0;
            this.button1.Text = "Abrir Informe Asistencia";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // txtCodMateria
            // 
            this.txtCodMateria.Location = new System.Drawing.Point(270, 93);
            this.txtCodMateria.Name = "txtCodMateria";
            this.txtCodMateria.Size = new System.Drawing.Size(255, 22);
            this.txtCodMateria.TabIndex = 1;
            // 
            // ReporteAsistencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtCodMateria);
            this.Controls.Add(this.button1);
            this.Name = "ReporteAsistencia";
            this.Text = "ReporteAsistencia";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtCodMateria;
    }
}