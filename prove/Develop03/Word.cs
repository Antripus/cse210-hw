internal class Word
{

    private string _word;
    private string _hideWord;
    private Boolean _isHide =false;

    public Word(string palabra) //word son palabra del texto en el versiculo
    {
        _word = palabra;
        _hideWord = hide();
    }

    private string hide (){
       
        string newWord="";
        for (int i=0; i<_word.Length; i++)
        {
            newWord = newWord + "_";
        }
        return newWord;
    }

    public string getWord()
    {
        return _word;
    }

    public string getHideord()
    {
        return _hideWord;
    }
    public Boolean getIsHide()
    {
        return _isHide;
    }

    public void hideWord()
    {
        _isHide = true;
        _word = _hideWord;
    }

}