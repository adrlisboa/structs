using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace structs
{
    internal class Program
    {

        struct Produto
        {
            public string nome;
            public float preco;
            public float peso;
            public string marca;

            //construtor \/
            public Produto(string nome, float preco, float peso, string marca)
            {
                this.nome = nome; //variavel do atributo = (recebe) variavel do parametro
                this.preco = preco;
                this.peso = peso;
                this.marca = marca;
            }

            //funções \/
            public void ExibirInfo()
            {
                Console.WriteLine($"Nome: {this.nome}");
                Console.WriteLine($"Preço: R${this.preco}");
                Console.WriteLine($"Peso: {this.peso} KG");
                Console.WriteLine($"Marca: {this.marca}");
            }

            /*public void AdicionarCupom(float porc)
            {
                float desconto = this.preco * porc / 100f;
                Console.WriteLine(this.preco - desconto);
            }*/

            public float AdicionarCupom(float porc)
            {
                float desconto = this.preco * porc / 100f;
                return this.preco - desconto;
            }
        }

        static void Main(string[] args)
        {
            /*Produto bola = new Produto();
            bola.nome = "Wilson";
            bola.preco = 14f;
            bola.peso = 1f;
            bola.marca = "Nike";
            
            Produto balde = new Produto();
            balde.nome = "balde de metal";
            balde.preco = 10f;
            balde.peso = 1.5f;
            balde.marca = "Marshall";*/

            Produto bola = new Produto("Wilson", 80f, 1f, "Nike");
            Produto balde = new Produto("Balde de metal", 15f, 1.5f, "Marshall");

            bola.ExibirInfo(); //pegue os campos da var bola e exiba no console
            Console.WriteLine("======================");
            balde.ExibirInfo(); //pegue os campos da var balde e exbiba no console

            float valorFinal = bola.AdicionarCupom(50f);
            balde.AdicionarCupom(50f);


            Console.WriteLine(valorFinal);

            Console.ReadLine();
        }
    }
}
