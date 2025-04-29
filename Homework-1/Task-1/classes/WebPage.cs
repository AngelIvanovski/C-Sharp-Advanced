using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Homework_1;

namespace Homework_1.classes
{
    public class WebPage : ISearchable
    {
        public WebPage(string text)
        {
            Text = text;
        }
        public string Text { get; set; }

        public string Search(string word)
        {
            if (Text.Contains(word))
            {
                return $"The word '{word}' was found in the webpage.";
            }
            else
            {
                return $"The word '{word}' was not found in the webpage.";
            }
        }
    }
}
