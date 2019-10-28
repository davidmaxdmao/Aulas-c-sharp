using System;
using System.Collections.Generic;
using System.Text;

namespace RevisaoSegundaUnidade
{
    class Animais
    {
        public string nome;
        public string animal;
        public string especie;
        public double peso;
        public int idade;
        public string hora_de_dormir;

        public void Andar()
        {
            if (this.animal == "baleia" || this.animal == "Baleia" || this.animal == "BALEIA")
            {
                Console.WriteLine("Este animal nada!");
            }

            if (this.animal == "cachorro" || this.animal == "Cachorro" || this.animal == "CACHORRO")
            {
                Console.WriteLine("Este animal corre");
            }

            if (this.animal == "cobra")
            {
                Console.WriteLine("Este animal rasteja");
            }

            if (this.animal == "tartaruga")
            {
                Console.WriteLine("Este animal anda lentamente");
            }
            
        }

        public void Comer()
        {
            if (this.idade < 1)
            {
                Console.WriteLine("Este animal come alimentos liquidos ou pastosos!");
            }

            if (this.peso > 20)
            {
                Console.WriteLine("Este animal deve fazer dieta e exercicios!");
            }
        }

        public void Dormir()
        {
            if (this.animal == "morcego" || this.animal == "Morcego" || this.animal == "MORCEGO")
            {
                Console.WriteLine("Este animal dorme a noite!");
            }

        }

        public void Falar()
        {
            if (this.animal == "papagaio")
            {
                
                
            }
        }

        public void Nome()
        {
            Console.WriteLine("nome do animal: " + this.nome);
        }

        public void Animal()
        {
            Console.WriteLine("animal: " + this.animal);
        }

        public void Especie()
        {
            Console.WriteLine("especie: " + this.especie);
        }

        public void Peso()
        {
            Console.WriteLine("peso: " + this.peso);
        }

        public void Idade()
        {
            Console.WriteLine("idade: " + this.idade);
        }

        public void HoraDeDormir()
        {
            Console.WriteLine("hora de dormir: " + this.hora_de_dormir);
        }

    }
}
