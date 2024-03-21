using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GereClientes
{
    internal class Cliente
    {
        public string nome;
        public string nif;
        public List<Compra> compras;
            
        public Cliente(string nome, string nif)
        {
            this.nome = nome;
            this.nif = nif;
            this.compras = new List<Compra>();
        }

        public override string ToString()
        {
            return nome + " (" + nif + ")";
        }
    }

    internal class LinhaCompra
    {
        public string descricao;
        public float valor;

        public LinhaCompra(string descricao, float valor)
        {
            this.descricao = descricao;
            this.valor = valor;
        }

        public override string ToString()
        {
            return descricao + " - " + valor + "€";
        }
    }

    internal class Compra
    {
        public List<LinhaCompra> linhas;

        public Compra()
        {
            linhas = new List<LinhaCompra>();
        }

        public void AdicionaLinha(LinhaCompra linha)
        {
            linhas.Add(linha);
        }

        public float getTotal()
        {
            return linhas.Sum(l => l.valor);
        }

        public override string ToString()
        {
            return DateTime.Now.ToString() + this.getTotal();
        }
    }
}
