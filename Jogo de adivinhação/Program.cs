namespace Jogo_de_adivinhação
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***************************************");
            Console.WriteLine("* Bem-Vindo(a) ao jogo da adivinhaçao *");
            Console.WriteLine("***************************************");
            Console.WriteLine();
            Console.WriteLine("Escolha o nível de dificuldade: ");
            Console.Write("(1) Fácil (2) Médio (3) Dificil\nEscolha:" );
            int dificuldade = Convert.ToInt32(Console.ReadLine());
            Random rand = new Random();
            int aleatorio = rand.Next(1,20);
            int chance = 0;
            int pontosJogador = 1000;

            if (dificuldade == 1)
            {
                chance = 15;
                Console.WriteLine("Vôce tem" + chance + " chance");
            }
            else if (dificuldade == 2)
            {
                chance = 10;
                Console.WriteLine("Vôce tem " + chance + " chance");
            }
            else if (dificuldade == 3)
            {
               chance = 5;
                Console.WriteLine("Vôce tem " + chance + " chance");
            }
            for (int i = 0; i < chance; i++)
            {
                
                Console.WriteLine("Tente adivinhar um número de 1 a 20 ");
                Console.WriteLine("--------------------------------------");
                Console.Write("Qual é o seu chute?");
                int tentativa = int.Parse(Console.ReadLine());
                Console.WriteLine("Você fez " + pontosJogador + " pontos!");
                pontosJogador = Math.Abs(pontosJogador - (tentativa + aleatorio) / 2);
                Console.WriteLine();
                
                if (tentativa == aleatorio )
                {
                 
                    Console.WriteLine("Acertou");
                    Console.WriteLine(pontosJogador);
                    break;
                }
                else if (chance - 1 == i)
                {
                    Console.WriteLine("Voce morreu");
                    Console.WriteLine(pontosJogador);
                    break;

                }
                else if(tentativa > aleatorio)
                {
                   
                    Console.WriteLine("Tenta um numero menor ai magrão");

                }

                else if (tentativa < aleatorio)
                {
                    Console.WriteLine("Tenta um numero maior ai magrão");
                    
                }
            
               
            }
            
        }
    }
}