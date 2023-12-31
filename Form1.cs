﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using winforms_correios.Modelo;

namespace winforms_correios
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            Controle controle = new Controle();
            Endereco endereco = controle.pesquisarEndereco(txbCep.Text);
            if (controle.mensagem.Equals(""))
            {
                lblLogradouro.Text = endereco.logradouro;
                lblBairro.Text = endereco.bairro;
                lblCidade.Text = endereco.cidade;
            }
            else
            {
                MessageBox.Show(controle.mensagem);
            }
        }
    }
}
