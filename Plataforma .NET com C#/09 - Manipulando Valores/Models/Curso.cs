using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _09___Manipulando_Valores.Models
{
    public class Curso
    {
        public string Nome { get; set; }
        public List<Pessoa> Alunos { get; set; }

        
        public void AdicionarAluno(Pessoa aluno)
        {
            Alunos.Add(aluno);
        }

        public int ObterQuantidadeDeAlunosMatriculados()
        {
            int quantidade = Alunos.Count;
            return quantidade;
        }

        public void RemoverAluno(Pessoa aluno)
        {
            Alunos.Remove(aluno);
        }

        public void ListarAlunos()
        {
            Console.WriteLine($"Alunos do curso de: {Nome}, total: {ObterQuantidadeDeAlunosMatriculados()}");

            for (int i = 0; i < Alunos.Count; i++)
            {
                string texto = "Aluno N° " + i + " - " + Alunos[i].NomeCompleto;
                Console.WriteLine(texto);
            }

        }
    }

}