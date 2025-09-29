using System;


namespace MyApp

{

    internal class Program

    {

        static void Main(string[] args)

        {

            int win, lose, draw;
            int contw = 0, contl = 0, contd = 0;

            win = 0;
            lose = 0;

            char a1, a2, a3, b1, b2, b3, c1, c2, c3;

            a1 = '/';
            a2 = '/';
            a3 = '/';
            b1 = '/';
            b2 = '/';
            b3 = '/';
            c1 = '/';
            c2 = '/';
            c3 = '/';


            Console.WriteLine("Vamos jogar jogo da velha! \nEu sou o 'O', voce joga primeiro!\n");

            Console.WriteLine("onde você joga?\n");


            Random bot = new Random();

            do
            {

                a1 = '/';
                a2 = '/';
                a3 = '/';
                b1 = '/';
                b2 = '/';
                b3 = '/';
                c1 = '/';
                c2 = '/';
                c3 = '/';

                win = 0;
                lose = 0;
                draw = 0;

                int move = 0;

                do
                {

                    Console.WriteLine("    1   2   3 \n a  {0} | {1} | {2} \n b  {3} | {4} | {5} \n c  {6} | {7} | {8} \n", a1, a2, a3, b1, b2, b3, c1, c2, c3);

                    string p = Console.ReadLine();


                    if ((p == "1a") && (a1 == '/'))
                    {
                        a1 = 'X';
                        move++;
                    }

                    if ((p == "2a") && (a2 == '/'))
                    {
                        a2 = 'X';
                        move++;
                    }

                    if ((p == "3a") && (a3 == '/'))
                    {
                        a3 = 'X';
                        move++;
                    }

                    if ((p == "1b") && (b1 == '/'))
                    {
                        b1 = 'X';
                        move++;
                    }

                    if ((p == "2b") && (b2 == '/'))
                    {
                        b2 = 'X';
                        move++;
                    }

                    if ((p == "3b") && (b3 == '/'))
                    {
                        b3 = 'X';
                        move++;
                    }

                    if ((p == "1c") && (c1 == '/'))
                    {
                        c1 = 'X';
                        move++;
                    }

                    if ((p == "2c") && (c2 == '/'))
                    {
                        c2 = 'X';
                        move++;
                    }

                    if ((p == "3c") && (c3 == '/'))
                    {
                        c3 = 'X';
                        move++;
                    }


                    // bot joga
                    Random acaobot = new Random();
                    int feito = 0;

                    while (feito == 0)
                    {

                        int numero = acaobot.Next(1, 10);

                        if ((numero == 1) && (a1 == '/'))
                        {
                            a1 = 'O';
                            feito = 1;
                            move++;
                        }

                        if ((numero == 2) && (a2 == '/'))
                        {
                            a2 = 'O';
                            feito = 1;
                            move++;
                        }

                        if ((numero == 3) && (a3 == '/'))
                        {
                            a3 = 'O';
                            feito = 1;
                            move++;
                        }

                        if ((numero == 4) && (b1 == '/'))
                        {
                            b1 = 'O';
                            feito = 1;
                            move++;
                        }

                        if ((numero == 5) && (b2 == '/'))
                        {
                            b2 = 'O';
                            feito = 1;
                            move++;
                        }

                        if ((numero == 6) && (b3 == '/'))
                        {
                            b3 = 'O';
                            feito = 1;
                            move++;
                        }

                        if ((numero == 7) && (c1 == '/'))
                        {
                            c1 = 'O';
                            feito = 1;
                            move++;
                        }

                        if ((numero == 8) && (c2 == '/'))
                        {
                            c2 = 'O';
                            feito = 1;
                            move++;
                        }

                        if ((numero == 9) && (c3 == '/'))
                        {
                            c3 = 'O';
                            feito = 1;
                            move++;
                        }

                    }


                    if ((a1 == 'X') && (a2 == 'X') && (a3 == 'X'))
                    {
                        win = 2;
                    }

                    if ((b1 == 'X') && (b2 == 'X') && (b3 == 'X'))
                    {
                        win = 2;
                    }

                    if ((c1 == 'X') && (c2 == 'X') && (c3 == 'X'))
                    {
                        win = 2;
                    }

                    if ((a1 == 'X') && (b1 == 'X') && (c1 == 'X'))
                    {
                        win = 2;
                    }

                    if ((a2 == 'X') && (b2 == 'X') && (c2 == 'X'))
                    {
                        win = 2;
                    }

                    if ((a3 == 'X') && (b3 == 'X') && (c3 == 'X'))
                    {
                        win = 2;
                    }

                    if ((a1 == 'X') && (b2 == 'X') && (c3 == 'X'))
                    {
                        win = 2;
                    }

                    if ((a3 == 'X') && (b2 == 'X') && (c1 == 'X'))
                    {
                        win = 2;
                    }


                    if ((a1 == 'O') && (a2 == 'O') && (a3 == 'O'))
                    {
                        lose = 2;
                    }

                    if ((b1 == 'O') && (b2 == 'O') && (b3 == 'O'))
                    {
                        lose = 2;
                    }

                    if ((c1 == 'O') && (c2 == 'O') && (c3 == 'O'))
                    {
                        lose = 2;
                    }

                    if ((a1 == 'O') && (b1 == 'O') && (c1 == 'O'))
                    {
                        lose = 2;
                    }

                    if ((a2 == 'O') && (b2 == 'O') && (c2 == 'O'))
                    {
                        lose = 2;
                    }

                    if ((a3 == 'O') && (b3 == 'O') && (c3 == 'O'))
                    {
                        lose = 2;
                    }

                    if ((a1 == 'O') && (b2 == 'O') && (c3 == 'O'))
                    {
                        lose = 2;
                    }

                    if ((a3 == 'O') && (b2 == 'O') && (c1 == 'O'))
                    {
                        lose = 2;
                    }

                    if (move == 9)
                    {
                        draw = 2;
                        contd++;
                    }


                } while ((win < 2) && (lose < 2) && (draw < 2));


                if (lose >= 1)
                {
                    Console.WriteLine("O 'O' Ganhou");
                    contl++;
                }

                if (win >= 1)
                {
                    Console.WriteLine("O 'X' Ganhou");
                    contw++;
                }
                if (draw >= 1)
                {
                    Console.WriteLine("Empate :/");
                }


                Console.WriteLine("Quer jogar denovo?");
                string r = Console.ReadLine();

                if (r != "sim")
                {
                    break;
                }

                Console.WriteLine(" Rank \n Vitorias player : {0} \n Vitorias Bot: {1} \n Empates {2}", contw, contl, contd);


            } while (true);

        }

    }

}
