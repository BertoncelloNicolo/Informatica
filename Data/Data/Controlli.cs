using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    static internal class Controlli
    {
        public static bool bisestile(int anno)
        {
            if ((anno % 4 == 0 && anno % 100 != 0) || anno % 400 == 0)//controllo per il bisestile
            {
                return true;
            }
            return false;
        }

        public static bool Controllo_mese(int mese)
        {
            if (mese > 12 || mese < 1)//se il mese è minore di 1 o maggiore di 12
            {
                return false;//il metodo ritorna false
            }
            return true;//altrimenti ritorna true
        }
        public static bool Controllo_Giorno(int giorno) 
        {
            if (giorno > 31 || giorno < 1)//se il giorno è minore di 1 o maggiore di 31 
            {
                return false;//il metodo ritorna false 
            }
            return true;//altrimenti ritorn true 
        }
        public static bool Sintassi(string data_scritta)
        {
            int giorno, mese, anno;
            ClasseData data_tmp; //creo una data tmp 
            string[] data_split = data_scritta.Split('/');//uso string split per dividere giorno mese anno con "/"

            if (data_split.Length != 3)//controllo che la lunghezza dell'array con lo split della stringa sia lungo 3 sennò ritorno falso
            {
                return false;
            } 
                
            if (!int.TryParse(data_split[0], out giorno) || !int.TryParse(data_split[1], out mese) || !int.TryParse(data_split[2], out anno))//se non inserisco dei valori validi ritorna false 
            {
                return false;
            }

            data_tmp = new ClasseData(giorno, mese, anno);//se tutto è andato a buon fine richiamo il costrutture master per la creazone della data
            return true; 
        }
    }
}

