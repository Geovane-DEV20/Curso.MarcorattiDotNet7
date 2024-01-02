using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Metodos
{
    public class MinhaClasse
    {


        public void Saudacao()
        {
            Console.WriteLine("Bem vindo meu Jovem");
            ExibirDataAtual();
            Saudacao("Geovane", DateTime.Now.ToShortTimeString());//Passagem de argumentos
        }
        public void Saudacao(string nome, string data)=>
            Console.WriteLine(nome);
        public void ExibirDataAtual() =>
            Console.WriteLine(DateTime.Now.ToShortTimeString());
        
        public void Resultado(Aluno aluno)
        {
            Console.WriteLine($"Nome: {aluno.Nome}, Sexo: {aluno.Sexo}" +
                $"Idade: {aluno.Idade}");

            if(aluno.Aprovado == "S")
            {
                Console.WriteLine("Você foi aprovado");
            }
            else
            {
                Console.WriteLine("Vc não foi aprovado");
            }
        }
    }
}
