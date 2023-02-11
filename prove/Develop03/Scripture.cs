public class Scripture
{


private Reference _referencia;
private List<Word> _parrafoPorPalabras = new List<Word> ();

public Scripture(Reference referencia, string parrafo)
    {
        _referencia = referencia;
        string[] parrafoPorPalabras = parrafo.Split(' ');

        foreach (string p in parrafoPorPalabras)
        {
            Word word = new Word(p);
            
            _parrafoPorPalabras.Add(word);
        }
    }

public void displayScripture()
{
    Console.WriteLine();
    string referencia = _referencia.getReferenceString();
    Console.Write (referencia + " ");

    foreach (Word p in _parrafoPorPalabras)
        {
            Console.Write(p.getWord() + ' ');
        }
}

   public void hideWorlds()
    {
        
        List<Word> newParrafo = new List<Word> ();
        int cantPalabras = _parrafoPorPalabras.Count();
        int palabrasEscondidas = getCantPalabrasEscondidas();
        int repeticiones = cantPalabras /5;
        Random rand = new Random();

        while(repeticiones > 0){
            int posicionRandom = rand.Next(0, cantPalabras);
            int posicion = 0;
            foreach (Word p in _parrafoPorPalabras)
            {
                if (p.getIsHide() == false && posicionRandom == posicion){
                    p.hideWord();
                    repeticiones = repeticiones -1;
                }
                posicion = posicion +1;
            }
            if (cantPalabras == getCantPalabrasEscondidas())
            {
                repeticiones = 0;
            } 
        }
    }

    public  int getCantPalabrasEscondidas(){
        int cant = 0;
        foreach (Word p in _parrafoPorPalabras)
        {
            if (p.getIsHide() == true){
                cant =cant + 1;
            }
        }
        return cant;
    }


    public  int getCantPalabras(){
        return _parrafoPorPalabras.Count();
    }
}