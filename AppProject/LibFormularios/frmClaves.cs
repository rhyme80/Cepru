﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibFormularios
{
    public partial class frmClaves : LibFormularios.frmPadre
    {
        public frmClaves()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CargarArchivoTxt("Txt Files |*ClavesRespuesta*.sdf");
            procesar();
            panel1.Visible = false;
            label1.Visible = false;
        }

        private void procesar()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Tema", typeof(string));
            dt.Columns.Add("Respuesta", typeof(string));

            for (int i = 0; i < dgvDatos.Rows.Count; i++)
            {
                if (dgvDatos[0, i].Value.ToString().Trim().Length != 1 || dgvDatos[1, i].Value.ToString().Trim().Length != 50 || dgvDatos[0, i].Value.ToString().Contains(" ") || dgvDatos[1, i].Value.ToString().Contains(" "))
                {
                    dgvDatos.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                    dt.Rows.Add(dgvDatos[0, i].Value.ToString(), dgvDatos[1, i].Value.ToString());
                }
            }

            dgvErrores.DataSource = dt;
            dgvErrores.AutoResizeColumns();
        }

        public override string NombreTabla()
        {
            string nombre = "TClaveRespuesta";
            return nombre;
        }
        public override DataTable Tabla()
        {
            DataTable dt = CreateDataTable();
            dgvDatos.Columns.Clear();
            return dt;
        }

        private DataTable CreateDataTable()
        {
            // Creamos un nuevo objeto DataTable

            DataTable dt = new DataTable();

            dt.Columns.Add("tema", typeof(string));
            dt.Columns.Add("clave", typeof(string));
            for (int i = 0; i < dgvDatos.Rows.Count; i++)
            {
                dt.Rows.Add(dgvDatos[0, i].Value.ToString(), dgvDatos[1, i].Value.ToString());
            }

            return dt;
        }

        public override void Grabar()
        {
            base.Grabar();
        }
    }
}
