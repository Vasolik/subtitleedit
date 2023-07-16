using System.Collections.Generic;
using System.Linq;
using System.Text;
using Nikse.SubtitleEdit.Core.Common;

namespace Nikse.SubtitleEdit.Core.Translate.Service
{
    public class SerbianLettersService : ITranslationService
    {
        private static Dictionary<string, string> mapCyrToLat = new Dictionary<string, string>();
        private static Dictionary<string, string> mapLatToCyr = new Dictionary<string, string>();

        static SerbianLettersService()
        {
            mapCyrToLat.Add("а", "a");
            mapCyrToLat.Add("б", "b");
            mapCyrToLat.Add("в", "v");
            mapCyrToLat.Add("г", "g");
            mapCyrToLat.Add("д", "d");
            mapCyrToLat.Add("ђ", "đ");
            mapCyrToLat.Add("е", "e");
            mapCyrToLat.Add("ж", "ž");
            mapCyrToLat.Add("з", "z");
            mapCyrToLat.Add("и", "i");
            mapCyrToLat.Add("ј", "j");
            mapCyrToLat.Add("к", "k");
            mapCyrToLat.Add("л", "l");
            mapCyrToLat.Add("љ", "lj");
            mapCyrToLat.Add("м", "m");
            mapCyrToLat.Add("н", "n");
            mapCyrToLat.Add("њ", "nj");
            mapCyrToLat.Add("о", "o");
            mapCyrToLat.Add("п", "p");
            mapCyrToLat.Add("р", "r");
            mapCyrToLat.Add("с", "s");
            mapCyrToLat.Add("т", "t");
            mapCyrToLat.Add("ћ", "ć");
            mapCyrToLat.Add("у", "u");
            mapCyrToLat.Add("ф", "f");
            mapCyrToLat.Add("х", "h");
            mapCyrToLat.Add("ц", "c");
            mapCyrToLat.Add("ч", "č");
            mapCyrToLat.Add("џ", "dž");
            mapCyrToLat.Add("ш", "š");

            mapCyrToLat.Add("А", "A");
            mapCyrToLat.Add("Б", "B");
            mapCyrToLat.Add("В", "V");
            mapCyrToLat.Add("Г", "G");
            mapCyrToLat.Add("Д", "D");
            mapCyrToLat.Add("Ђ", "Đ");
            mapCyrToLat.Add("Е", "E");
            mapCyrToLat.Add("Ж", "Ž");
            mapCyrToLat.Add("З", "Z");
            mapCyrToLat.Add("И", "I");
            mapCyrToLat.Add("Ј", "J");
            mapCyrToLat.Add("К", "K");
            mapCyrToLat.Add("Л", "L");
            mapCyrToLat.Add("Љ", "Lj");
            mapCyrToLat.Add("М", "M");
            mapCyrToLat.Add("Н", "N");
            mapCyrToLat.Add("Њ", "Nj");
            mapCyrToLat.Add("О", "O");
            mapCyrToLat.Add("П", "P");
            mapCyrToLat.Add("Р", "R");
            mapCyrToLat.Add("С", "S");
            mapCyrToLat.Add("Т", "T");
            mapCyrToLat.Add("Ћ", "Ć");
            mapCyrToLat.Add("У", "U");
            mapCyrToLat.Add("Ф", "F");
            mapCyrToLat.Add("Х", "H");
            mapCyrToLat.Add("Ц", "C");
            mapCyrToLat.Add("Ч", "Č");
            mapCyrToLat.Add("Џ", "Dž");
            mapCyrToLat.Add("Ш", "Š");

            mapLatToCyr.Add("a", "а");
            mapLatToCyr.Add("b", "б");
            mapLatToCyr.Add("v", "в");
            mapLatToCyr.Add("g", "г");
            mapLatToCyr.Add("d", "д");
            mapLatToCyr.Add("đ", "ђ");
            mapLatToCyr.Add("e", "е");
            mapLatToCyr.Add("ž", "ж");
            mapLatToCyr.Add("z", "з");
            mapLatToCyr.Add("i", "и");
            mapLatToCyr.Add("j", "ј");
            mapLatToCyr.Add("k", "к");
            mapLatToCyr.Add("l", "л");
            mapLatToCyr.Add("lj", "љ");
            mapLatToCyr.Add("lJ", "љ");
            mapLatToCyr.Add("m", "м");
            mapLatToCyr.Add("n", "н");
            mapLatToCyr.Add("nj", "њ");
            mapLatToCyr.Add("nJ", "њ");
            mapLatToCyr.Add("o", "о");
            mapLatToCyr.Add("p", "п");
            mapLatToCyr.Add("r", "р");
            mapLatToCyr.Add("s", "с");
            mapLatToCyr.Add("t", "т");
            mapLatToCyr.Add("ć", "ћ");
            mapLatToCyr.Add("u", "у");
            mapLatToCyr.Add("f", "ф");
            mapLatToCyr.Add("h", "х");
            mapLatToCyr.Add("c", "ц");
            mapLatToCyr.Add("č", "ч");
            mapLatToCyr.Add("dž", "џ");
            mapLatToCyr.Add("dŽ", "џ");
            mapLatToCyr.Add("š", "ш");

            mapLatToCyr.Add("A", "А");
            mapLatToCyr.Add("B", "Б");
            mapLatToCyr.Add("V", "В");
            mapLatToCyr.Add("G", "Г");
            mapLatToCyr.Add("D", "Д");
            mapLatToCyr.Add("Đ", "Ђ");
            mapLatToCyr.Add("E", "Е");
            mapLatToCyr.Add("Ž", "Ж");
            mapLatToCyr.Add("Z", "З");
            mapLatToCyr.Add("I", "И");
            mapLatToCyr.Add("J", "Ј");
            mapLatToCyr.Add("K", "К");
            mapLatToCyr.Add("L", "Л");
            mapLatToCyr.Add("Lj", "Љ");
            mapLatToCyr.Add("LJ", "Љ");
            mapLatToCyr.Add("M", "М");
            mapLatToCyr.Add("N", "Н");
            mapLatToCyr.Add("Nj", "Њ");
            mapLatToCyr.Add("NJ", "Њ");
            mapLatToCyr.Add("O", "О");
            mapLatToCyr.Add("P", "П");
            mapLatToCyr.Add("R", "Р");
            mapLatToCyr.Add("S", "С");
            mapLatToCyr.Add("T", "Т");
            mapLatToCyr.Add("Ć", "Ћ");
            mapLatToCyr.Add("U", "У");
            mapLatToCyr.Add("F", "Ф");
            mapLatToCyr.Add("H", "Х");
            mapLatToCyr.Add("C", "Ц");
            mapLatToCyr.Add("Č", "Ч");
            mapLatToCyr.Add("Dž", "Џ");
            mapLatToCyr.Add("DŽ", "Џ");
            mapLatToCyr.Add("Š", "Ш");
        }
        public string GetName()
        {
            return "Serbian Script transformer.";
        }
        
        public override string ToString()
        {
            return GetName();
        }

        public string GetUrl()
        {
            return "localhost";
        }

        public List<string> Translate(string sourceLanguage, string targetLanguage, List<Paragraph> sourceParagraphs)
        {
            return sourceParagraphs.Select(p => targetLanguage == "sr" || targetLanguage == "sr-cyrl" ? ToCyrillic(p.Text) : ToLatin(p.Text)).ToList();
        }

        public int GetMaxTextSize()
        {
            return 100_000;
        }

        public int GetMaximumRequestArraySize()
        {
            return 100000;
        }

        public List<TranslationPair> GetSupportedSourceLanguages()
        {
            return new List<TranslationPair>
            {
                new TranslationPair("SERBIAN_LATIN", "sr-Latn"),
                new TranslationPair("SERBIAN", "sr-cyrl"),
            };
        }

        public List<TranslationPair> GetSupportedTargetLanguages()
        {
            return new List<TranslationPair>
            {
                new TranslationPair("SERBIAN_LATIN", "sr-Latn"),
                new TranslationPair("SERBIAN", "sr-cyrl"),
            };
        }

        private static string ToCyrillic(string text)
        {
            int i;
            var sb = new StringBuilder();
            var isInsideHtmlTag = false;
            var htmlTagStartIndex = -1;
            var textLower = text.ToLower();
            for (i = 0; i < text.Length; i++)
            {
                if (isInsideHtmlTag)
                {
                    if (textLower[i] == '>' )
                    {
                        sb.Append(text.Substring(htmlTagStartIndex, i - htmlTagStartIndex + 1));
                        isInsideHtmlTag = false;
                        continue;
                    }

                    if (i + 1 >= text.Length)
                    {
                        i = htmlTagStartIndex;
                    }
                    continue;
                }

                if (textLower[i] == '<' && i + 1 < text.Length)
                {
                    isInsideHtmlTag = true;
                    htmlTagStartIndex = i;
                    continue;
                }
                if (i < text.Length - 1)
                {
                    if (!(textLower[i] != 'n' && textLower[i] != 'l' || textLower[i + 1] != 'j'))
                    {
                        sb.Append(mapLatToCyr[string.Concat(text[i], text[i + 1])]);
                        i++;
                        continue;
                    }
                    else if (!(textLower[i] != 'd' || textLower[i + 1] != 'ž'))
                    {
                        sb.Append(mapLatToCyr[string.Concat(text[i], text[i + 1])]);
                        i++;
                        continue;
                    }
                }

                char chr;
                if (!mapLatToCyr.ContainsKey(text[i].ToString()))
                {
                    chr = text[i];
                    sb.Append(chr.ToString());
                }
                else
                {
                    var strs = mapLatToCyr;
                    chr = text[i];
                    sb.Append(strs[chr.ToString()]);
                }
            }
            return sb.ToString();
        }

        private static string ToLatin(string text)
        {
            var stringBuilder = new StringBuilder();
            foreach (var str in text.Select(chr => (!mapCyrToLat.ContainsKey(chr.ToString()) ? chr.ToString() : mapCyrToLat[chr.ToString()])))
            {
                stringBuilder.Append(str);
            }
            return stringBuilder.ToString();
        }
    }
}