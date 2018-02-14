using ConsumindoServico.ServiceReference1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsumindoServico
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            string cpf = txtCpf.Text;

            try
            {
                ClienteServiceClient serviceClient = new ClienteServiceClient();
                Cliente ccad = new Cliente();
                ccad.Nome = nome;
                ccad.CPF = cpf;

                serviceClient.Add(ccad);

                MessageBox.Show("Cliente cadastrado com sucesso!!!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadatrar "+ ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClienteServiceClient serviceClient = new ClienteServiceClient();
            Cliente cliente = new Cliente();

            cliente = serviceClient.Get(txtNome.Text);

            txtCpf.Text = cliente.CPF;
        }
    }
}
