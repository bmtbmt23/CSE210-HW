using System;

Class Word
{
    private string _text;
    
    private bool _isHidden;
    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }
    public void Hide()
    {
        isHidden = true;
    }
    public bool IsHidden()
    {
        retrurn _isHidden;
        
    }
       public string GetDisplayText()
       {
           if (_isHidden)
           {
               return new string ("_" _text.Length);
           }
           else
           {
               return _text;
           }
       }
}