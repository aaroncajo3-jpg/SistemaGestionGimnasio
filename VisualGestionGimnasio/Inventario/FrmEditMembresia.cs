using Entidades.Inventario;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VisualGestionGimnasio.Inventario
{
    public partial class FrmEditMembresia : Form
    {
        public FrmEditMembresia()
        {
            InitializeComponent();
            LlenarTipoMembresia();
            //this.StartPosition = FormStartPosition.CenterScreen;
            //this.WindowState = FormWindowState.Maximized;
            
        }

      

        public bool ValidarDatos()
        {
            if (cbxTipo.Text.Trim().Length == 0 ||
                txtDuracion.Text.Trim().Length == 0 ||
                txtPrecio.Text.Trim().Length == 0 ||
                txtDecripcion.Text.Trim().Length == 0 ||
                txtIdMembresia.Text.Trim().Length == 0)
            {
                return false;
            }

            return true;
        }

        public void Guardar()
        {
            try
            {
                if (ValidarDatos())
                {
                    this.DialogResult = DialogResult.OK;

                }
                else
                    MessageBox.Show("Los campos con (*) son obligatorios");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void LlenarTipoMembresia()
        {
            cbxTipo.Items.Add("Básica");
            cbxTipo.Items.Add("Premium");
            cbxTipo.Items.Add("VIP");
            cbxTipo.Items.Add("Estudiante");
            cbxTipo.Items.Add("Prueba");
        }

        public Membresia CrearObjeto()
        {
            Membresia membresia = new Membresia();
            membresia.IdMembresia = Convert.ToInt32(txtIdMembresia.Text);
            membresia.Nombre = cbxTipo.Text;
            membresia.DuracionDias = Convert.ToInt32(txtDuracion.Text);
            membresia.Precio = Convert.ToDecimal(txtPrecio.Text);
            membresia.Descripcion = txtDecripcion.Text;
            membresia.Estado = checkBox1.Checked;
            return membresia;
        }

        public void SetDatos(Membresia ob)
        {
            txtIdMembresia.Text = ob.IdMembresia.ToString();
            cbxTipo.Text = ob.Nombre;
            txtDuracion.Text = ob.DuracionDias.ToString();
            txtPrecio.Text = ob.Precio.ToString();
            txtDecripcion.Text = ob.Descripcion;
            checkBox1.Checked = ob.Estado;
        }

        private void cbxTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbxTipo.Text)
            {
                case "Básica":
                    txtDuracion.Text = "30";
                    break;

                case "Premium":
                    txtDuracion.Text = "90";
                    break;

                case "VIP":
                    txtDuracion.Text = "365";
                    break;

                case "Estudiante":
                    txtDuracion.Text = "180";
                    break;

                case "Prueba":
                    txtDuracion.Text = "7";
                    break;
            }
        }
    }
}
