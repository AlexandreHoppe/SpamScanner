//Alexandre Hoppe
//Project
//Scan an email for spam
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpamScanner
{
    class WordList
    {
        string scamWord;
        public void setScamWord(int wordSelected)
        {
            string[] scamList = new string[] {"shipping", "today", "here", "available", "fingertips", "online","free", "cash", "earn", "extra", "make money", "million", "bonus",
                "incredible deal", "full refund", "lifetime", "miracle", "success", "risk", "click", "click below", "subscribe", "you have been selected", "congratulations", "amazing", "diet",
                "got all", "real", "offer", "limited ", "order now ", "sold out"};
            scamWord = scamList[wordSelected];

        }

        public string getScamword()
        {
            return scamWord;
        }
    }
}
