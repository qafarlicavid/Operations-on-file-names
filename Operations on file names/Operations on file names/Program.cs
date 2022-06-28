using System;

namespace Operations_on_file_names
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Document doc = new Document(".jpg", ".png", ".docx");
            Console.WriteLine("Please select the language : ");
            Console.WriteLine("1.Azerbaijani \n 2.Russian \n 3.arabic");
            int command = Convert.ToInt32(Console.ReadLine());
            switch (command)
            {
                case 1:
                    Console.WriteLine(doc.Azerbaijani());
                    goto TryAgain;
                case 2:
                    Console.WriteLine(doc.Russian());
                    goto TryAgain;
                case 3:
                    Console.WriteLine(doc.Arabic());
                    goto TryAgain;
                default:
                    break;
            }
        TryAgain:
            string targettext = Console.ReadLine();
            Console.WriteLine(doc.IsCheckDocument(targettext));
            string targettext2 = Console.ReadLine();

        }
    }
    class Document
    {
        private string[] _extension;
        public Document(params string[] extension)
        {
            _extension = extension;
        }
        public string IsCheckDocument(string extension)
        {
            string text = "";
            for (int i = 0; i < extension.Length; i++)
            {
                if (text[i] == '.')
                {
                    for (int k = i; k < text.Length; k++)
                    {
                        text += text[k];
                    }
                }
            }
            foreach (string extsn in _extension)
            {
                if (extsn == text)
                {
                    return "Sisteme elave olundu";
                }
            }
            return "duzgun daxil edin";
        }
        public bool isExtensionHave()
        {
            if (_extension.Length == 0)
            {
                return false;
            }
            return true;
        }
        public string ReturnExtension(string text)
        {
            string newtext = "";
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == '.')
                {
                    for (int k = i; k < text.Length; k++)
                    {
                        newtext += text[k];
                    }
                }
            }
            foreach (string extsn in _extension)
            {
                if (extsn == text)
                {
                    return "hoy";
                }
            }
            return "aee";
        }
        public string Azerbaijani()
        {
            return "Azerbaijan dilini sectiniz";
        }
        public string Russian()
        {
            return "Вы выбрали русский";
        }
        public string Arabic()
        {
            return "لقد اخترت العربية";
        }
    }
}
