using System;

namespace RegjistrimiINxenesve
{
    class Program
    {
        static void Main(string[] args)
        {
            int veprimi = 0;
            int vitiShkollor = 0;

            Shkolla samiFrasheri = new Shkolla();

            Klasa klasa1 = new Klasa(10, 1, Drejtimi.Natyror);
            Klasa klasa2 = new Klasa(11, 1, Drejtimi.Shoqeror);
            Klasa klasa3 = new Klasa(12, 1, Drejtimi.Matematikor);
            Klasa klasa4 = new Klasa(10, 2, Drejtimi.Natyror);
            Klasa klasa5 = new Klasa(11, 2, Drejtimi.Shoqeror);
            Klasa klasa6 = new Klasa(12, 2, Drejtimi.Matematikor);
            Klasa klasa7 = new Klasa(10, 3, Drejtimi.Natyror);
            Klasa klasa8 = new Klasa(11, 3, Drejtimi.Shoqeror);
            Klasa klasa9 = new Klasa(12, 3, Drejtimi.Matematikor);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("|Regjistrimi i Nxenesve ne Shkolle te Mesme|");
            Console.WriteLine("--------------------------------------------");
        Fillimi:
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\nShtyp 1 per te shtuar nje nxenes ne drejtimin Natyror");
            Console.WriteLine("Shtyp 2 per te shtuar nje nxenes ne drejtimin Shoqeror");
            Console.WriteLine("Shtyp 3 per te shtuar nje nxenes ne drejtimin Matematikor\n");
            Console.WriteLine("Shtyp 4 per ndaluar programin\n");

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("Zgjedhni veprimin: ");

            try
            {

                veprimi = int.Parse(Console.ReadLine());
                if (veprimi == 4)
                {
                    samiFrasheri.ShfaqKlasat();
                    Console.WriteLine("Programi perfundoi!");
                    goto Fundi;
                }
            }
            catch (Exception)
            {

                Console.WriteLine("\nJepni nje numer");
            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\nShtyp 5 per te shtuar nxenesin ne klasen e 10-te");
            Console.WriteLine("Shtyp 6 per te shtuar nxenesin ne klasen e 11-te");
            Console.WriteLine("Shtyp 7 per te shtuar nxenesin ne klasen e 12-te");
            Console.WriteLine("---------------------------");
        Viti:
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("Zgjedhni veprimin: ");

            try
            {
                vitiShkollor = int.Parse(Console.ReadLine());

            }
            catch (Exception)
            {
                Console.WriteLine("Jep nje numer real");
            }
            Console.ForegroundColor = ConsoleColor.White;
            switch (veprimi)
            {
                case 1:
                    {
                        switch (vitiShkollor)
                        {
                            case 5:
                                {
                                    Nxenesi nxenesi = new Nxenesi();
                                    nxenesi.InicializoTeDhenat();
                                    klasa1.ShtoAntarNeLista(nxenesi);
                                    samiFrasheri.ShtoAntarNeLista(klasa1);
                                    goto Fillimi;
                                }
                            case 6:
                                {
                                    Nxenesi nxenesi = new Nxenesi();
                                    nxenesi.InicializoTeDhenat();
                                    klasa2.ShtoAntarNeLista(nxenesi);
                                    samiFrasheri.ShtoAntarNeLista(klasa2);
                                    goto Fillimi;
                                }
                            case 7:
                                {
                                    Nxenesi nxenesi = new Nxenesi();
                                    nxenesi.InicializoTeDhenat();
                                    klasa3.ShtoAntarNeLista(nxenesi);
                                    samiFrasheri.ShtoAntarNeLista(klasa3);
                                    goto Fillimi;
                                }

                            default:
                                {
                                    Console.WriteLine("\nKur te zgjedhni veprimin mund te jepni si hyrje vetem numrat {5,6,7}\n");
                                    goto Viti;

                                }
                        }

                    }
                case 2:
                    {
                        switch (vitiShkollor)
                        {
                            case 5:
                                {
                                    Nxenesi nxenesi = new Nxenesi();
                                    nxenesi.InicializoTeDhenat();
                                    klasa4.ShtoAntarNeLista(nxenesi);
                                    samiFrasheri.ShtoAntarNeLista(klasa4);
                                    goto Fillimi;
                                }
                            case 6:
                                {
                                    Nxenesi nxenesi = new Nxenesi();
                                    nxenesi.InicializoTeDhenat();
                                    klasa5.ShtoAntarNeLista(nxenesi);
                                    samiFrasheri.ShtoAntarNeLista(klasa5);
                                    goto Fillimi;
                                }
                            case 7:
                                {
                                    Nxenesi nxenesi = new Nxenesi();
                                    nxenesi.InicializoTeDhenat();
                                    klasa6.ShtoAntarNeLista(nxenesi);
                                    samiFrasheri.ShtoAntarNeLista(klasa6);
                                    goto Fillimi;
                                }

                            default:
                                {
                                    Console.WriteLine("\nKur te zgjedhni veprimin mund te jepni si hyrje vetem numrat {5,6,7}\n");
                                    goto Viti;

                                }
                        }


                    }
                case 3:
                    {
                        switch (vitiShkollor)
                        {
                            case 5:
                                {
                                    Nxenesi nxenesi = new Nxenesi();
                                    nxenesi.InicializoTeDhenat();
                                    klasa7.ShtoAntarNeLista(nxenesi);
                                    samiFrasheri.ShtoAntarNeLista(klasa7);
                                    goto Fillimi;
                                }
                            case 6:
                                {
                                    Nxenesi nxenesi = new Nxenesi();
                                    nxenesi.InicializoTeDhenat();
                                    klasa8.ShtoAntarNeLista(nxenesi);
                                    samiFrasheri.ShtoAntarNeLista(klasa8);
                                    goto Fillimi;
                                }
                            case 7:
                                {
                                    Nxenesi nxenesi = new Nxenesi();
                                    nxenesi.InicializoTeDhenat();
                                    klasa9.ShtoAntarNeLista(nxenesi);
                                    samiFrasheri.ShtoAntarNeLista(klasa9);
                                    goto Fillimi;
                                }

                            default:
                                {
                                    Console.WriteLine("\nKur te zgjedhni veprimin mund te jepni si hyrje vetem numrat {5,6,7}\n");
                                    goto Viti;

                                }
                        }



                    }
                default:
                    {
                        Console.WriteLine("\nKur te zgjedhni veprimin mund te jepni si hyrje vetem numrat {1,2,3,4}\n");
                        goto Fillimi;

                    }
            }
            Fundi:

            Console.ReadLine();
        }
    }
}
