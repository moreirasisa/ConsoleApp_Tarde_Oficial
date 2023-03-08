using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Tarde
{
    public class Produto
    {
        private int Id;
        private string Descricao;
        private decimal Valor;

        public Produto(int id, string descricao, decimal valor)
        {
            Id = id;
            Descricao = descricao;
            Valor = valor;
        }
        public string getId()
        {
            return "\tCódigo: " + Id;
        }
        public string getDescricao()
        {
            return "\tDescrição: " + Descricao;
        }
        public string getValor()
        {
            return "\tValor em R$: " + Valor;
        }
    }
}
