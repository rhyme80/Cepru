﻿namespace LibFormularios
{
    partial class frmRespuestasAlumnos
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
            this.pnBotones.SuspendLayout();
            this.pnTitulo.SuspendLayout();
            this.pnContenido.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbTitulo
            // 
            this.lbTitulo.Text = "RESPUESTAS DE ALUMNOS";
            // 
            // button1
            // 
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmRespuestasAlumnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 466);
            this.Name = "frmRespuestasAlumnos";
            this.Text = "frmRespuestasAlumnos";
            this.pnBotones.ResumeLayout(false);
            this.pnTitulo.ResumeLayout(false);
            this.pnContenido.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
    }
}