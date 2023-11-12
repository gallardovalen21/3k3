using MaterialSkin.Controls;
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
    public partial class MenuMock :MaterialForm
    {
        readonly MaterialSkin.MaterialSkinManager materialSkinManager;
        public MenuMock()
        {
            materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Indigo500, MaterialSkin.Primary.Indigo700, MaterialSkin.Primary.Indigo100, MaterialSkin.Accent.Pink200, MaterialSkin.TextShade.WHITE);

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

        private void materialButton1_Click(object sender, EventArgs e)
        {
            PantallaConsulta pantalla = new PantallaConsulta(Program.setGestor());
            this.Hide();
            pantalla.Show();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
