using Controlador.Inventario;
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
using VisualGestionGimnasio.Inventario;

namespace VisualGestionGimnasio.Seguridad
{
    public partial class FrmAdminMemb : Form
    {
        public FrmAdminMemb()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.WindowState = FormWindowState.Maximized;
            this.Resize += FrmAdminMembresia_Resize;
        }

        private void CentrarBotonesToolStrip(ToolStrip toolStrip)
        {
            int anchoBotones = 0;

            foreach (ToolStripItem item in toolStrip.Items)
            {
                if (item.Available)
                    anchoBotones += item.Width;
            }

            int margenIzquierdo = (toolStrip.Width - anchoBotones) / 2;

            if (margenIzquierdo < 0)
                margenIzquierdo = 0;

            bool primero = true;

            foreach (ToolStripItem item in toolStrip.Items)
            {
                if (primero)
                {
                    item.Margin = new Padding(margenIzquierdo, 0, 0, 0);
                    primero = false;
                }
                else
                {
                    item.Margin = new Padding(0);
                }
            }
        }

        private void FrmAdminMembresia_Resize(object sender, EventArgs e)
        {
            CentrarBotonesToolStrip(toolStrip1);
        }

        MembresiaLN olnm = new MembresiaLN();

        public void ListarMembresias()
        {
            dataGridView1.DataSource = olnm.ShowMembresiaFiltro("");
        }

        private void FrmAdminMemb_Load(object sender, EventArgs e)
        {
            ListarMembresias();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = olnm.ShowMembresiaFiltro(textBox1.Text);
        }

        public void Nuevo()
        {
            try
            {
                FrmEditMembresia frm = new FrmEditMembresia();
                frm.Text = "Insertar Categoria";
                frm.label1.Text = "Insertar Categoria";
                frm.ShowDialog();
                if (frm.DialogResult == DialogResult.OK)
                {
                    Membresia obj = frm.CrearObjeto();
                    olnm.CreateMembresia(obj);
                    frm.Close();
                    MessageBox.Show("Categoria ingresada correctamente");
                    ListarMembresias();

                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(" Error al Insertar Categoria" + ex.Message);
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Nuevo();
        }
    }
}
