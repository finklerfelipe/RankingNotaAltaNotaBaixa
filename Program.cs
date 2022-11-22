using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desafio_G2._4
{
    class Program
    {

        static void Main(string[] args)
        {
            int contador = 0;

            Aluno notaMaisAlta = null;
            Aluno notaMaisBaixa = null;

            while (contador < 9)
            {
                Aluno pessoaObjeto = new Aluno();

                Console.WriteLine("Digite a matrícula da Pessoa {0}", contador + 1);
                pessoaObjeto.Matricula = Console.ReadLine();

                Console.WriteLine("Digite a nota da Pessoa {0}", contador + 1);
                pessoaObjeto.Nota = Int32.Parse(Console.ReadLine());

                contador++;

                if (notaMaisAlta == null)
                {                 
                    notaMaisAlta = pessoaObjeto;
                }

                else if (pessoaObjeto.Nota > notaMaisAlta.Nota)
                {
                    notaMaisAlta = pessoaObjeto;
                }

                if (notaMaisBaixa == null)
                {
                    notaMaisBaixa = pessoaObjeto;
                }

                else if (pessoaObjeto.Nota < notaMaisBaixa.Nota)
                {
                    notaMaisBaixa = pessoaObjeto;
                }

            }

            Console.WriteLine("");
            Console.WriteLine("A nota mais alta é do(a) {0} de nota {1}", notaMaisAlta.Matricula, notaMaisAlta.Nota);
            Console.WriteLine("A nota mais baixa é do(a) {0} de nota {1}", notaMaisBaixa.Matricula, notaMaisBaixa.Nota);

        }
    }
}
