namespace TestDome
{
    using System;

    public class NumericInput : TextInput
    {
        protected override bool isValid(char c)
        {
            return char.IsDigit(c);
        }
    }

    public class TextInput
    {
        private string input = string.Empty;

        public void Add(char c)
        {
            if (isValid(c)) input += c.ToString();
        }

        public string GetValue()
        {
            return input;
        }

        protected virtual bool isValid(char input)
        {
            return char.IsLetterOrDigit(input); //using system
        }
    }

    public class UserInputcs
    {
        public static void Main(string[] args)
        {
            TextInput input = new NumericInput();
            input.Add('1');
            input.Add('a');
            input.Add('0');
            Console.WriteLine(input.GetValue());//10
        }
    }
}
