using System;

namespace statistikait1B
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo keyinfo;
            string PZ = "0123456789";  //PZ = povolené znaky 
            string text = "";
            int soucet = 0;
            int pocet = 0;
            do
            {
                keyinfo = Console.ReadKey(true);
                if (PZ.Contains(keyinfo.KeyChar))
                {
                    //zde se program dostane při stisknutí čísla
                    text = text + keyinfo.KeyChar; //text += keyinfo.KeyChar;
                    Console.Write(keyinfo.KeyChar);


                }
                else if (keyinfo.Key == ConsoleKey.Enter)
                {
                    if(text != "")
                    {
                        soucet += int.Parse(text);
                        pocet++;
                    }
                    Console.WriteLine();
                    text = "";

                }
                else if (keyinfo.Key == ConsoleKey.Backspace && text.Length > 0)
                {
                    Console.Write("\b \b");
                    text = text.Substring(0, text.Length - 1);

                }
            }   while (keyinfo.Key != ConsoleKey.Escape);

        }
    }
}
