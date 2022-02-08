namespace Chapter9
{
    class VowelsAndConsonants
    {
        private readonly string str;

        public static void Run()
        {
            string text = "The lazy fox jumps over a cat";

            VowelsAndConsonants vc = new VowelsAndConsonants(text);


            System.Console.WriteLine($"There are {vc.GetVowels(text)} vowels in the text.");

            System.Console.WriteLine($"There are {vc.GetConsonants(text)} consonants in the text.");

            GetVowelsAndConsonants(text);
        }

        public VowelsAndConsonants(string str)
        {
            this.str = str;
        }

        public int GetVowels(string str)
        {
            int index = 0;
            int vowels = 0;

            while (index < str.Length)
            {
                if (str[index] == 'a' || str[index] == 'e' || str[index] == 'i' || str[index] == 'o'
                    || str[index] == 'u' || str[index] == 'y' || str[index] == 'w')
                {
                    vowels++;
                }
                index++;
            }

            return vowels;
        }

        public int GetConsonants(string str)
        {
            int index = 0;
            int consonants = 0;

            while (index < str.Length)
            {
                if (!(str[index] == 'a' || str[index] == 'e' || str[index] == 'i' || str[index] == 'o'
                    || str[index] == 'u' || str[index] == 'y' || str[index] == 'w'))
                {
                    consonants++;
                }
                index++;
            }

            return consonants;
        }

        public static void GetVowelsAndConsonants(string str)
        {
            int index = 0;
            int vowels = 0;
            int consonants = 0;

            while (index < str.Length)
            {
                if (str[index] == 'a' || str[index] == 'e' || str[index] == 'i' || str[index] == 'o'
                    || str[index] == 'u' || str[index] == 'y' || str[index] == 'w')
                {
                    vowels++;

                }

                else
                {
                    consonants++;

                }
                index++;
            }
            System.Console.WriteLine($"The number of vowels are {vowels}");
            System.Console.WriteLine($"The number of consonants are {consonants}");

        }
    }
}
