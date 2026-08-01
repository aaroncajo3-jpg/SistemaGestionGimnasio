using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VisualGestionGimnasio.Seguridad
{
    public partial class FrmMenuMDI : Form
    {
        public FrmMenuMDI()
        {
            InitializeComponent();
        }

        private void mEMBRESIAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["FrmAdminMembresia"] == null)
            {
                FrmAdminMemb frmK = new FrmAdminMemb
                {
                    MdiParent = this
                };
                frmK.Show();
            }
        }
    }
}
