using System.Security.Cryptography;

namespace Data
{
    class ClasseData
    {
        int _giorno;//attributo giorno
        int _mese;//attributo mese
        int _anno;//attributo anno 
        int[] giorni_mese = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 }; //array con tutti i giorni dei mesi 

        public ClasseData(int giorno, int mese, int anno)
        {
            Anno = anno;
            if (Controllo_Bisestile()) //se l'anno è bisestile allora assegno a febbraio 29 giorni 
            {
                giorni_mese[1] = 29;
            }
            Mese = mese;
            Giorno = giorno;
        }
        public int Giorno
        {
            get
            {
                return _giorno;
            }
            private set
            {
                if (value > 31 || value < 1)//se il giorno è minore di 1 o maggiore di 31 
                {
                    _giorno = 1;//assegno il giorno a 1 
                }
                else
                {
                    _giorno = value;
                }
            }
        }
        public int Mese
        {
            get
            {
                return _mese;
            }
            private set
            {
                if (value > 12 || value < 1)//se il mese è minore di 1 o maggiore di 12
                {
                    _mese = 1;//assegno il mese a 1
                }
                else
                {
                    _mese = value;
                }
            }
        }
        public int Anno
        {
            get { return _anno; }
            private set { _anno = value; } //assegno l'anno senza alcun controllo
        }
        public ClasseData() : this(1, 1, 2023)
        {

        }
        public bool Controllo_Bisestile()
        {
            return ((_anno % 4 == 0 && _anno % 100 != 0) || _anno % 400 == 0);//controllo per l'anno bisestile
        }
        public void Incremento_Giorni(int giorni)
        {
            for (int i = 0; i < giorni; i++)//ciclo per i giorni 
            {
                _giorno++;// incremento giorni 
                if (_giorno > giorni_mese[_mese - 1])//se arrivo al numero massimo di giorni incremento il mese
                {
                    _mese++;
                    _giorno = 1; //e assegno 1 al giorno
                    if (_mese > 12) //se arrivo al numero massimo di mesi
                    {
                        _mese = 1; //assegno 1 al mese
                        _anno++; //incremento l'anno 
                    }
                }
            }
        }
        public void Decremento_Giorni(int giorni)
        {
            for (int i = 0; i < giorni; i++)//ciclo per i giorni 
            {
                _giorno--;// incremento giorni 
                if (_giorno == 0)//se arrivo comn i giorni a zero
                {
                    _mese--; //tolgo 1 mese

                    if (_mese == 0) //se arrivo a 0 con i mesi ricomincio dall'anno prima a dicembre
                    {
                        _mese = 12; //assegno 12 al mese
                        _anno--; //incremento l'anno 
                    }
                    _giorno = giorni_mese[_mese - 1]; //assegno al giorno i giorni del mese prima 
                }
            }
        }
        public string NomeMese()
        {
            string mese_lettere = ((NomeMesi)_mese - 1).ToString(); //dall'enumeratore reperisco il nome del mese
            return mese_lettere; //ritorno il nome del mese che mi serve 
        }
        public static bool ControlloSintassiData(string data_scritta)
        {
            int giorno, mese, anno;
            ClasseData data_tmp; //creo una data tmp 
            string[] data_split = data_scritta.Split('/');//uso string split per dividere giorno mese anno con "/"
            if (data_split.Length != 3) //controllo che la lunghezza dell'array con lo split della stringa sia lungo 3 sennò ritorno falso
                return false;
            if (!int.TryParse(data_split[0], out giorno) || !int.TryParse(data_split[1], out mese) || !int.TryParse(data_split[2], out anno))
                return false;
            data_tmp = new ClasseData(giorno, mese, anno);//se tutto è andato a buon fine richiamo il costrutture master per la creazone della data
            return data_tmp.Giorno != 1 && data_tmp.Mese != 1;
        }
    }
}
