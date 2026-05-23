using System;
using System.Collections.Generic;
class Scripture
{

    private Reference _reference;
    private List<Word> _words;

    private Random _random = new Random();

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();

        string[] words = text.Split (" ");
        
        foreach(string word in words)
        {
            _words.Add(new Word(word));
        }
    }   
        public void HideRandomWords( int numberToHide)
        {
            Random random = new Random();
            int hiddenNumber = 0;
               
               while (hiddenNumber < numberToHide)
               {
                int label = _random.Next(_words.Count);
                
                if (!_words[label].IsHidden())
                {
                    _words[label].Hide();
                    hiddenNumber++;
                }
                
                }
        }
       
                public bool IsCompletelyHidden()
                {
                    foreach (Word word in _words)
                    {
                        if (!word.IsHidden())
                        {
                            return false;
                        }
                    }
                       
                        return true;
                }

        public string GetDisplayText()
            
            {
                string text = "";
                
                foreach (Word word in _words)
        {
            text += word.GetDisplayText() + " ";
        }

        return _reference.GetDisplayText() + " " + text.Trim();
            
            }
            
        }
