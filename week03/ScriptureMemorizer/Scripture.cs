using System;
using System.Collections.Generic;
class Scripture
{
    private Reference _reference;
    private List<Word> _words;

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
            int HiddenNumber = 0;
               
               while (hiddenNumber < numberToHide)
               {
                int label = random.Next(_words.Count);
                
                if (!_words[label].IsHidden())
                {
                    _words[label].hide();
                    hiddenNumber++;
                       
                    foreach (Word word in _words)
                    {
                        text += word.GetDisplayText(0) + " ";
                    }
                    
                    return $"{_reference.GetDisplayText()} - {text.Trim()}";
                }
                public bool IsCompleteHidden()
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
                   
                }
            }
        }
    }
}