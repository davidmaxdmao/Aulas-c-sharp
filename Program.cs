using System;

namespace RevisaoSegundaUnidade
{
    class Program
    {
        static void Main(string[] args)
        {
            Animais a = new Animais();
            DonoAnimal d = new DonoAnimal();
            a.animal = "tartaruga";
            a.idade = 0;
            a.nome = "simon";
            a.Andar();
            a.Comer();
            a.Nome();

            d.NomeDono = "david";
            d.NomeAnimal = a.nome;
            d.Dono();


        }
    }
}
