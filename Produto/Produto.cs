using System;
using System.Globalization;

namespace Produto
{
    class Produto
    {
        private string _nome;
        private double _preco;
        private int _qtd;

        public Produto()
        {

        }

        public Produto(string nome, double preco, int qtd)
        {
            _nome = nome;
            _preco = preco;
            _qtd = qtd;
        }

        public string GetNome()
        {
            return _nome;
        }

        public void SetNome(string nome)
        {
            _nome = nome;
        }

        public double ValorTotalEmEstoque() {
            return _preco * _qtd;
        }


        public void AdicionarProdutos(int quantidade)
        {
            _qtd = _qtd + quantidade;
        }

        public void RemoverProdutos(int quantidade)
        {
            _qtd -= quantidade;
        }

        public override string ToString()
        {
            return _nome 
                + ", R$ " + 
                _preco.ToString("F2",CultureInfo.InvariantCulture)
                + ","
                + _qtd
                + " unidades, Total: R$"
                + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
