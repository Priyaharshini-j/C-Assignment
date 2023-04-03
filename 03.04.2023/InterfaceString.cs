namespace Assignment3
{
    /*
     * English to Pig Latin Translator

            Pig latin has two very simple rules:

            If a word starts with a consonant move the first letter(s) of the word, till you reach a vowel, to the end of the word and add "ay" to the end.
            have ➞ avehay
            cram ➞ amcray
            take ➞ aketay
            cat ➞ atcay
            shrimp ➞ impshray
            trebuchet ➞ ebuchettray
            If a word starts with a vowel add "yay" to the end of the word.
            ate ➞ ateyay
            apple ➞ appleyay
            oaken ➞ oakenyay
            eagle ➞ eagleyay
            Write two functions to make an English to pig latin translator. The first function TranslateWord(word) takes a single word and returns that word translated into pig latin. 
            The second function TranslateSentence(sentence) takes an English sentence and returns that sentence translated into pig latin.

            Examples
            TranslateWord("flag") ➞ "agflay"

            TranslateWord("Apple") ➞ "Appleyay"

            TranslateWord("button") ➞ "uttonbay"

            TranslateWord("") ➞ ""

            TranslateSentence("I like to eat honey waffles.") ➞ "Iyay ikelay otay eatyay oneyhay afflesway."


            TranslateSentence("Do you think it is going to rain today?") ➞ "Oday ouyay inkthay ityay isyay oinggay otay ainray odaytay?"
        Notes
        Regular expressions will help you not mess up the punctuation in the sentence.
        If the original word or sentence starts with a capital letter, the translation should preserve its case (see examples #2, #5 and #6).
     */
    internal class InterfaceString
    {
        static void Main(string[] args)
        {
            Translate translate = new Translation();
            Console.WriteLine("Enter a Sentence");
            string inputWords=Console.ReadLine()!;
            Console.WriteLine(translate.TranslateSentence(inputWords));
        }
    }

    interface Translate
    {
        string TranslateWord(string inputWord);
        string TranslateSentence(string inputSentence);
    }

    class Translation : Translate
    {
        public string TranslateWord(string inputWord)
        {
            inputWord = inputWord.ToLower();
            // We are using this below line to separate the Punctuation from the word and storing it
            string SpeChar = new string(inputWord.Where(char.IsPunctuation).ToArray());
            //We are using this below line to get only the digit or letter from the word
            inputWord = new string(inputWord.Where(char.IsLetterOrDigit).ToArray());
            char[] words= inputWord.ToCharArray();

            if (IsVowel(inputWord[0]))
            {
               return inputWord+ "yay"+SpeChar;
            }
            int counter = 1;
            while (true)
            {
                if (IsVowel(words[counter]))
                    break;
                counter++;
            }
            return inputWord.Substring(counter)+ inputWord.Substring(0,counter)+"ay"+SpeChar;
        }
        public string TranslateSentence(string inputSentence) {

            string[] input = inputSentence.Split(" ");
            
            string resWord = "";
            foreach(string word in input)
            {
                resWord+=TranslateWord(word)+" ";
            }
            return resWord;
        }
        
        public static bool IsVowel(char inputWord)
        {
            if (inputWord == 'a' || inputWord == 'e' || inputWord== 'i' || inputWord == 'o'|| inputWord == 'u' ) 
                return true;
            return false;
        }
    }
}
