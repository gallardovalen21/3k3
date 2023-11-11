using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace G1_PPA1_E1.Pantallas
{
    public partial class MenuMock : Form
    {
        public MenuMock()
        {
            InitializeComponent();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            PantallaConsulta pantalla = new PantallaConsulta(Program.setGestor());
            this.Hide();
            pantalla.Show();

        }

        private void MenuMock_Load(object sender, EventArgs e)
        {

        }
    }
}
