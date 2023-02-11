public class Reference
{

    private string _book;
    private int _chapter;
    private int _startVers;
    private int _endVers;
     

    public Reference (string book, int chapter, int startVers, int endVers){ // Constructor versiculo unico

        _book = book;
        _chapter = chapter;
        _startVers = startVers;
        _endVers = endVers;
    }


    public Reference (string book, int chapter, int startVers){ //contructor Rango

        _book = book;
        _chapter = chapter;
        _startVers = startVers;
    }

    public string getReferenceString (){
        if (_endVers == 0)
        {
            string referencia = _book + " " + _chapter + ": " + _startVers + " ";
            return referencia;
        }
        else
        {
            string referencia = _book + " " + _chapter + ": " + _startVers + " - " + _endVers;
            return referencia;
        }
    }

}