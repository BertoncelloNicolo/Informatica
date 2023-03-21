using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    internal class Stack
    {
        int[] stack;
        int stack_pointer = -1; // punta all'ultimo elemento, se uguale a -1 vuol dire che è vuoto
        int dimensione; //variabile che indica la dimensione 

        public Stack() : this(10) //se non inserisco la dimensione crea uno stack di 10 elementi 
        {
            stack_pointer = -1;
        }
        public Stack(int dimensione)
        {
            stack = new int[dimensione];
            stack_pointer = -1;
        }
        public int GetElementi //ritorna il numero di elementi presenti nello stack
        {
            get
            {
                int i;
                for (i = 0; i < stack.Length && stack[i] != 0; i++) //for  a vuoto per il conteggio degli elementi 
                {
                    ; ;
                }
                return i;//ritorno l'indice che mi dice il conteggio 
            }

        }

        public void Push(int push)
        {
            if (GetElementi < stack.Length)
            {
                int[] tmp = new int[stack.Length];

                if (!int.TryParse(push.ToString(), out int inserito) || inserito <= 0)
                {
                    throw new Exception("Elemento non valido");
                }
                tmp[0] = inserito; 

                for (int i = 1; i < GetElementi + 1; i++) //faccio lo swap di tutti gli elementi 
                {
                    tmp[i] = stack[i - 1];
                }

                stack = tmp;
                stack_pointer = GetElementi - 1; ////cambio l'elemento a deve puntare lo stack pointer 
            }
            else
            {
                throw new Exception("Lo stack è pieno");
            }
        }

        public int Pop
        {
            get
            {
                if (GetElementi > 0)
                {
                    int pop = stack[0];
                    int[] tmp = new int[stack.Length];

                    for (int i = 0; i < GetElementi; i++)//for per copiare tutti gli elementi nell'stacktmp
                    {
                        tmp[i] = stack[i + 1];
                    }

                    stack = tmp;
                   
                    if (stack[GetElementi] != 0)
                    {
                        stack_pointer = GetElementi - 1; //cambio l'elemento a deve puntare lo stack pointer 
                    }

                    else
                    {
                        stack_pointer = -1; //se elimino l'ultimo elemento il puntatore va a -1
                    }

                    return pop; //ritorna l'elemento eliminato
                }
                else
                {
                    return -1;
                }
            }
        }

        public string Stampa //metodo per formattare la stringa di output 
        {
            get
            {
                if (GetElementi > 0) //condizione per elementi maggiori di 0 
                {
                    string tmp = "";

                    for (int i = 0; i < GetElementi; i++)
                    {
                        tmp += i == GetElementi - 1 ? $"{stack[i]}" : $"{stack[i]}\n";
                    }

                    return tmp;
                }
                else
                {
                    return "Lo stack è vuoto";
                }
            }
        }
        public int Cima //ritorna l'elemento in cima allo stack 
        {
            get
            {
                if (GetElementi > 0)
                {
                    return stack[0];
                }
                else
                {
                    return -1;
                }
            }
        }
        public void Reset() //resetto lo stack ponenedo tutti gli elementi a 0 
        {
            for (int i = 0; i < GetElementi; i++)
            {
                stack[i] = 0;
            }
        }
        public List<int> Data // ritorna lo stack convertito in lista
        {
            get { return stack.ToList(); }
        }
        public override string ToString() // override del ToString per scrivere nella ListBox 
        {
            return Stampa;
        }


    }
}