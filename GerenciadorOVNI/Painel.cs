﻿using System;
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
    public partial class Painel : Form
    {
        //Objetos Globais:
        BibliotecaOVNI.OVNI ovni;


        public Painel(BibliotecaOVNI.OVNI ovni)
        {
            InitializeComponent();
            this.ovni = ovni;
            AtualizaDados();
            cbmPlanetas.DataSource = BibliotecaOVNI.OVNI.PlanetasValidos;
        }

        //Metodo para atualizar os dados:
        public void AtualizaDados()
        {
            lblAbduzidos.Text = "Abduzidos: " + ovni.QtdAbduzidos;
            lblTripulantes.Text = "Tripulantes: " + ovni.QtdTripulantes;
            lblSituacao.Text = "Situação: " + (ovni.Situacao ? "Ligado" : "Desligado");
            lblPlaneta.Text = "Planeta: " + ovni.PlanetaAtual;
        }

        private void Painel_Load(object sender, EventArgs e)
        {

        }

        private void btnAddTripulante_Click(object sender, EventArgs e)
        {

        }

        private void btnAbduzir_Click(object sender, EventArgs e)
        {
            
        }

        private void btnLigar_Click(object sender, EventArgs e)
        {
            if (ovni.Ligar() == false )
            {

                MessageBox.Show("A nave ja está Ligada");

            }
            AtualizaDados();
        }

        private void btnDesligar_Click(object sender, EventArgs e)
        {
            if (ovni.Desligar() == false)
            {

                MessageBox.Show("A nave ja está Desligada");

            }
            AtualizaDados();
        }
    }
}
