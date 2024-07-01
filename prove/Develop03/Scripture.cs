public class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();

    public Scripture(Reference Reference, string text)
    {
        _reference = Reference;
        
        string [] words = text.Split(" ");
        foreach (string stringWord in words)
        {
            _words.Add(new Word(stringWord));
        }

    }

    public void HideRandomWords(int numberToHide)
    {
        foreach (Word word in _words)
        {
            Console.Clear();
            Console.WriteLine("________");
        }
    }

    public string GetDisplayText()
    {
       return "";
    }

    public void IsCompleteltHidden()
    {

    }
}