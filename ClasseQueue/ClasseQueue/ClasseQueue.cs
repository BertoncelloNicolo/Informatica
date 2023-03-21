using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseQueue
{
    internal class ClasseQueue
    {
        List<int> queue;

        public ClasseQueue(int dim)
        {
            if (dim < 1) //se la dimensione inserita è minore di 1 viene generata un'eccezione
                throw new Exception("Dimensione inserita non valida");
            queue = new List<int>(dim); //inizializzazione della queue
        }
        
        public ClasseQueue() : this(10) { } //costruttore base che restituisce la dimensione 10 al costruttore master 
        public void Enqueue(int n) //metodo che aggiunge un intero alla queue 
        {
            queue.Add(n);
        }

        public int Dequeue() //rimuove e ritorna l'elemento all'inizio della queue
        {
            if (queue.Count == 0) //se la queue è vuota genera un'eccezione
                throw new Exception("La queue non contiene nessun elemento");
            int tmp = queue[0]; //assegnazione a tmp del primo elemento della queue, ovvero quello da eliminare 
            for (int i = 0; i < queue.Count-1; i++) 
            {
                queue[i] = queue[i+1]; //sposto gli elementi verso la testa della queue 
            }
            queue.RemoveAt(queue.Count - 1); //elimina l'elemento di scarto
            return tmp;
        }

        public int Peek() //restituisce l'oggetto all'inizio della queue
        {
            return queue[0];
        }
        public void Clear() //metodo publico per ripristinare la queue
        {
            queue.Clear(); 
        }
        public List<int> GetElementi() //ritorna gli elementi della queue all'interno di un array 
        {
            return queue;
        }
    }
}
