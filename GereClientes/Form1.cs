using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GereClientes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Cliente c = listBoxClientes.SelectedItem as Cliente;
            if(c == null)
            {
                MessageBox.Show("Selecione um cliente");
                return;
            }

            Compra compra = new Compra();
            c.compras.Add(compra);
            listBoxCompras.Items.Add(compra);
        }

        private void buttonAddCliente_Click(object sender, EventArgs e)
        {
            if(textBoxClienteNome.Text == "" || textBoxClienteNif.Text == "")
            {
                MessageBox.Show("Preencha todos os campos","Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Cliente c = new Cliente(textBoxClienteNome.Text, textBoxClienteNif.Text);
            listBoxClientes.Items.Add(c);
            textBoxClienteNif.Clear();
            textBoxClienteNome.Clear();
        }

        private void listBoxClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cliente cliente = (Cliente)listBoxClientes.SelectedItem;
            labelNomeCliente.Text = cliente.nome;
            labelNifCliente.Text = cliente.nif; 
            listBoxCompras.Items.Clear();
            listBoxLinhasCompra.Items.Clear();
            foreach(Compra compra in cliente.compras)
            {
                listBoxCompras.Items.Add(compra);
            }

            if(cliente.compras.Count > 0)
            {
                listBoxCompras.SelectedIndex = 0;
            }
            this.refreshTotal();

        }

        private void buttonAddLinha_Click(object sender, EventArgs e)
        {
            string descricao = textBoxAddLinhaDescricao.Text;
            if(descricao == "")
            {
                MessageBox.Show("Preencha a descrição");
                return;
            }
            float valor = 0;
            try
            {
                valor = float.Parse(textBoxAddLinhaValor.Text);
            }catch(Exception ex)
            {
                MessageBox.Show("Preencha o valor", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxAddLinhaValor.Clear();
                return;
            }
            
            LinhaCompra linhaCompra = new LinhaCompra(descricao, valor);
            Cliente cliente = (Cliente)listBoxClientes.SelectedItem;
            if(cliente == null)
            {
                MessageBox.Show("Selecione um cliente");
                return;
            }

            Compra compra = listBoxCompras.SelectedItem as Compra;
            if(compra == null)
            {
                MessageBox.Show("Selecione ou crie uma compra");
                return;
            }
            
            this.adicionarLinhaCompra(compra, linhaCompra);    
        }

        private void adicionarLinhaCompra(Compra compra, LinhaCompra linhaCompra)
        {
            compra.linhas.Add(linhaCompra);
            listBoxLinhasCompra.Items.Add(linhaCompra);
            this.refreshTotal();
        }
        private void refreshTotal()
        {
            labelTotalClienteValor.Text = ((Cliente)listBoxClientes.SelectedItem).compras.Sum(c => c.linhas.Sum(l => l.valor)).ToString();
            if(listBoxCompras.SelectedItem != null)
            {
                labelTotalValor.Text = ((Compra)listBoxCompras.SelectedItem).linhas.Sum(l => l.valor).ToString();
            }
        }

        private void listBoxCompras_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxLinhasCompra.Items.Clear();
            Compra compra = listBoxCompras.SelectedItem as Compra;
            if(compra == null)
            {
                return;
            }
            compra.linhas.ForEach(l => listBoxLinhasCompra.Items.Add(l));
            this.refreshTotal();
        }

        private void buttonApagarLinhaCompra_Click(object sender, EventArgs e)
        {
            LinhaCompra l = (LinhaCompra)listBoxLinhasCompra.SelectedItem;
            if(l == null)
            {
                MessageBox.Show("Selecione uma linha");
                return;
            }
            Compra compra = (Compra)listBoxCompras.SelectedItem;
            compra.linhas.Remove(l);
            listBoxLinhasCompra.Items.Remove(l);
            this.refreshTotal();
        }

        private void buttonApagarCompra_Click(object sender, EventArgs e)
        {
            Compra c = (Compra)listBoxCompras.SelectedItem;
            if(c == null)
            {
                MessageBox.Show("Selecione uma compra");
                return;
            }
            Cliente cliente = (Cliente)listBoxClientes.SelectedItem;
            cliente.compras.Remove(c);
            listBoxCompras.Items.Remove(c);
            this.refreshTotal();
        }
    }
}
