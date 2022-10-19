using reading_files_with_linq.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;

namespace reading_files_with_linq
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string diretorio = @"C:\Users\matheus.silva\Documents\ProjetosPessoais\reading-files-with-linq\reading-files-with-linq\Produtos.csv";

            string[] linhas = File.ReadAllLines(diretorio);
            List<Product> produtos = new List<Product>();
            foreach (string linha in linhas)
            {
                string[] linhaDividida = linha.Split(",");
                string nome = linhaDividida[0];
                double preco = double.Parse((linhaDividida[1]), CultureInfo.InvariantCulture);
                produtos.Add(new Product(nome, preco));
            }

            var q1 = produtos.Average(p => p.Preco);
            Console.Write("Média de valores de produtos: ");
            Console.WriteLine(q1.ToString("F2", CultureInfo.InvariantCulture));

            var q2 = produtos.Where (p => p.Preco < q1).OrderByDescending(p => p.Nome).ToList();

            q2.ForEach(p => Console.WriteLine(p.Nome));
        }
    }
}
