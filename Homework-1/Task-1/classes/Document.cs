using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Homework_1;

namespace Homework_1.classes
{
    public class Documentt : ISearchable
    {

        public Documentt(string text)
        {
            Text = text;
        }

       public string Text { get; set; }


        public string Search(string word)
        {
            if (Text.Contains(word))
            {
                return $"The word '{word}' was found in the document.";
            }
            else
            {
                return $"The word '{word}' was not found in the document.";
            }
        }
    }
}

