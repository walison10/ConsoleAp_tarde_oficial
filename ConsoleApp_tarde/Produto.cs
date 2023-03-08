using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_tarde
{
    internal class Produto
    {
        private int id;
        private string Descricao;
        private decimal Valor;

        public Produto(int id, string descricao, decimal valor) 
        {
            id = id;
            Descricao = descricao
                Valor = valor;
        }
    }
}
