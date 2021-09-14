using System;

namespace Raphael_saldanha
{
    class Program
    {
        int pontosC1, pontosC2;
        enum Escolhas { Pedra, Papel, Tesoura };
        static Escolhas[] escolhas = { Escolhas.Pedra, Escolhas.Papel, Escolhas.Tesoura };
        static Escolhas C1, C2;
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {

                Console.WriteLine("-----------PARTIDA: " + i + "------------ ");
                Random rdn = new Random();
                C1 = escolhas[rdn.Next(0, escolhas.Length)];
                C2 = escolhas[rdn.Next(0, escolhas.Length)];

                coisa _coisa1;
                switch (C1)
                {
                    case Escolhas.Pedra:
                        _coisa1 = new pedra();
                        break;
                    case Escolhas.Papel:
                        _coisa1 = new Papel();
                        break;
                    case Escolhas.Tesoura:
                        _coisa1 = new tesoura();
                        break;
                    default:
                        _coisa1 = new coisa();
                        break;
                }

                Console.WriteLine("Escolha de C1: " + _coisa1.GetNome());

                coisa _coisa2;
                switch (C2)
                {
                    case Escolhas.Pedra:
                        _coisa2 = new pedra();
                        break;
                    case Escolhas.Papel:
                        _coisa2 = new Papel();
                        break;
                    case Escolhas.Tesoura:
                        _coisa2 = new tesoura();
                        break;
                    default:
                        _coisa2 = new coisa();
                        break;
                }
                Console.WriteLine("Escolha de C2: " + _coisa2.GetNome());

                string Resultdo = verifica(C1, C2);

                if (Resultdo == "")
                {
                    Console.WriteLine("Resultado: EMPATE");
                }
                else
                {
                    Console.WriteLine("Ganhador: " + Resultdo);
                }
                Console.WriteLine("-----------FIM DA PARTIDA------------ ");
            }

        }

        private static string verifica(Escolhas p1, Escolhas p2)
        {


            string ganhador = "";
            if (p1 == p2)
            {
                ganhador = "";
            }

            if (p1 == Escolhas.Pedra && p2 == Escolhas.Tesoura) { ganhador = "C1"; }
            if (p1 == Escolhas.Pedra && p2 == Escolhas.Papel) { ganhador = "C2"; }

            if (p1 == Escolhas.Papel && p2 == Escolhas.Pedra) { ganhador = "C1"; }
            if (p1 == Escolhas.Papel && p2 == Escolhas.Tesoura) { ganhador = "C2"; }

            if (p1 == Escolhas.Tesoura && p2 == Escolhas.Papel) { ganhador = "C1"; }
            if (p1 == Escolhas.Tesoura && p2 == Escolhas.Pedra) { ganhador = "C1"; }

            return ganhador;

        }
    }
}

