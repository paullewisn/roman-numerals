using System.Collections.Generic;

namespace RomanNumerals
{
    public static class Numerals
    {
        public static List<KeyValuePair<string, string>> TranslateToI()
        {
            var translate = new List<KeyValuePair<string, string>>
            {
                new KeyValuePair<string, string>("IV", IGenerator(4)),
                new KeyValuePair<string, string>("V", IGenerator(5)),
                new KeyValuePair<string, string>("XL", IGenerator(40)),
                new KeyValuePair<string, string>("L", IGenerator(50)),
                new KeyValuePair<string, string>("XC", IGenerator(90)),
                new KeyValuePair<string, string>("C", IGenerator(100)),
                new KeyValuePair<string, string>("IX", IGenerator(9)),
                new KeyValuePair<string, string>("X", IGenerator(10))
            };
            return translate;
        }


        public static List<KeyValuePair<string, string>> TranslateFromI()
        {
            var translate = new List<KeyValuePair<string, string>>
            {
                new KeyValuePair<string, string>(IGenerator(100), "C"),
                new KeyValuePair<string, string>(IGenerator(90), "XC"),
                new KeyValuePair<string, string>(IGenerator(50), "L"),
                new KeyValuePair<string, string>(IGenerator(40), "XL"),
                new KeyValuePair<string, string>(IGenerator(10), "X"),
                new KeyValuePair<string, string>(IGenerator(9), "IX"),
                new KeyValuePair<string, string>(IGenerator(5), "V"),
                new KeyValuePair<string, string>(IGenerator(4), "IV")
            };
            return translate;
        }

        public static string IGenerator(int count)
        {
            var output = string.Empty;
            for (var i = 0; i < count; i++)
            {
                output = output + "I";
            }
            return output;
        }

        public static string Addition(string num1, string num2)
        {
            var translated1 = TranslateInput(num1);
            var translated2 = TranslateInput(num2);

            var translateOutput = translated1 + translated2;


            foreach (var translation in TranslateFromI())
            {
                translateOutput = translateOutput.Replace(translation.Key, translation.Value);
            }

            return translateOutput;
        }

        public static string TranslateInput(string value)
        {
            foreach (var translation in TranslateToI())
            {
                value = value.Replace(translation.Key, translation.Value);
            }
            return value;
        }
    }
}