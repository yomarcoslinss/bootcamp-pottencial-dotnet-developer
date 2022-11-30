using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _08___Propriedades__Métodos_e_Construtores.Models
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
            foreach (Pessoa aluno in Alunos)
            {
                Console.WriteLine(aluno.NomeCompleto);
            }
        }
    }

}