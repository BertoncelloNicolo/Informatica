using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_console
{
    class Program
    {
        static ClasseStack stack = new ClasseStack();
        static void Main(string[] args)
        {
            bool fine=false;
            while (!fine)
            {
                Console.WriteLine("ecco lo stack \n");
                stampa();
                switch (Menu())
                {
                    case 1: Inserimento(); break;
                    case 2: Rimuovi(); break;
                    case 3: Elemento_In_Testa(); break;
                    case 4: Conteggio_Elementi(); break;
                    case 5: Reset(); break;
                    case 6: fine=true; Console.WriteLine("programma terminato"); break;
                }

                Console.ReadLine();
                Console.Clear();
            }
        }
        static int Menu()
        {
            string[] opzioni = { "1. pop ", "2. push", "3. elemento in testa", "4. Conteggio degli elmenti", "5. reset", "6. fine" };
            int scelta;

            Console.WriteLine("SCEGLI UN OPZIONE");
            for (int i = 0; i < opzioni.Length; i++)
            {
                Console.WriteLine(opzioni[i]);
            }
            return scelta = Convert.ToInt32(Console.ReadLine());
        }
        static void stampa()
        {
            string stampa = stack.Stampa;
        }
        static void Conteggio_Elementi()
        {
             Console.WriteLine(stack.GetElementi);
        }
        static void Inserimento()
        {
            Console.Clear();
            Console.WriteLine("Inserisci un elemento");
            try
            {
                stack.Push(Convert.ToInt32(Console.ReadLine()));
            }
            catch
            {
                Console.WriteLine("lo stack è pieno");
            }
        }
        static void Rimuovi()
        {
            Console.Clear();
            char scelta;
            Console.WriteLine("Sei sicuro di eliminare l'elemento ? Y/N");

            if (char.TryParse(Console.ReadLine().ToUpper(), out scelta))
            {
                if (scelta == 'Y')
                {
                    try
                    {
                        int tmp = stack.Pop;
                    }
                    catch
                    {
                        Console.WriteLine("stack vuoto");
                    }
                }
                else
                {
                    Console.WriteLine("hai scelto di non eliminare l'elemento");
                }
            }
            else
            {
                Console.WriteLine("Inserimento della scelta errato");
            }

        }
        static void Elemento_In_Testa()
        {
            Console.Clear();
            Console.WriteLine("ecco l'elemento in testa ");
            Console.WriteLine(stack.Cima);
            Console.ReadLine();
        }
        static void Reset()
        {
            Console.Clear();
            char scelta;
            Console.WriteLine("Sei sicuro di resettare lo stack ? Y/N");

            if (char.TryParse(Console.ReadLine().ToUpper(), out scelta))
            {
                if (scelta == 'Y')
                {
                    try
                    {
                        stack.Reset();
                    }
                    catch
                    {
                        Console.WriteLine("stack vuoto");
                    }
                }
                else
                {
                    Console.WriteLine("hai scelto di non resettare lo stack ");
                }
            }
            else
            {
                Console.WriteLine("Inserimento della scelta errato");
            }

        }

    }
}
