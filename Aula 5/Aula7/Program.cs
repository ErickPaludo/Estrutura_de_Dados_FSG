namespace Aula
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Exercício 7
            //Crie um programa que verifique se um aluno está aprovado.
            //Classe: Aluno
            //Atributos privados: _nome (string), _nota (double)
            //Propriedades públicas: Nome, Nota
            //Construtor: public Aluno(string nome, double nota)
            //Método: public bool Aprovado()
            //Uso no Main:
            Aluno a = new Aluno("Marina", 7.5);
            Console.WriteLine(a.Aprovado() ? "Aprovado" : "Reprovado");   
            Aluno b = new Aluno("Carlos", 5.9);
            Console.WriteLine(b.Aprovado() ? "Aprovado" : "Reprovado");
            //Saída esperada:
            //Aprovado

        }
    }
    public class Aluno
    {
        private string _nome;
        private double _nota;
        public string Nome { get; private set; }
       
        public double Nota { get;private set; }
        public Aluno(string nome, double nota)
        {
            _nome = nome;
            _nota = nota;
        }
        public bool Aprovado()
        {
            return _nota >= 6.0;
        }
    }
}

