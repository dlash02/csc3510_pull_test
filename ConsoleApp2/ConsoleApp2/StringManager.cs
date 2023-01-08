using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2 {
    public class StringManager {
        private string inString {  get; set; }

        public StringManager(string inString) {
            this.inString = inString;
        }

        public string remVowels( ) {
            string vowels = "aeiouAEIOU";
            string result = "";
     
                bool lastCharWasVowel = false;
                foreach (char c in this.inString) {
                    if (vowels.Contains(c)) {
                        lastCharWasVowel = true;
                    }
                    else if (c == 'y' && !lastCharWasVowel) {
                        lastCharWasVowel = true;
                    }
                    else {
                        if (c == 'y' && lastCharWasVowel) {
                            result += 'y';
                        }
                        else {
                            result += c;
                            lastCharWasVowel = false;
                        }
                    }
                }
            return result;
            }

        }
    }

