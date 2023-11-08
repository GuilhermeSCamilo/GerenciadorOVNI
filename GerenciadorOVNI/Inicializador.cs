using BibliotecaOVNI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerenciadorOVNI
{
    public partial class Inicializador : Form
    {
        public Inicializador()
        {
            InitializeComponent();
        }

        private void Inicializador_Load(object sender, EventArgs e)
        {
            cmbPlaneta.DataSource = BibliotecaOVNI.OVNI.PlanetasValidos;
            
           
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            //Obter Infos:

            int maxTripulantes = (int)nudTripulantes.Value;
            int maxAbduzidos = (int)nudAbduzidos.Value;
            string PlanetaOrigem = cmbPlaneta.Text;

            // Instanciar OVNI:

            BibliotecaOVNI.OVNI ovni = new BibliotecaOVNI.OVNI
                (maxTripulantes, maxAbduzidos, PlanetaOrigem);


            //Instanciar a janela do painel:
            Painel janela = new Painel(ovni);
            //Abrir janela
            janela.ShowDialog();
        }
    }
}
