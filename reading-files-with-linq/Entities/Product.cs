using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reading_files_with_linq.Entities
{
    class Product
    {
        public Product(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
        }

        public string Nome { get; set; }
        public double Preco { get; set; }

        public override string ToString()
        {
            return $"{Nome}, {Preco}";
        }
    }
}
