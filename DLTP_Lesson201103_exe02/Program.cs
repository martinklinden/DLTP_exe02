using System;

namespace DLTP_Lesson201103_exe02
{
    class Program
    {
        static void Main(string[] args)
        {
            string command;
            //string[] dictEntry = new string[7];
            string translateWords = "caput - huvud, videre - se, pater - far, arbor - träd, luna - måne, movere - flytta, urbs - stad";
            //Console.WriteLine(translateWords);
            string[] dictEntry = translateWords.Split(", ");
            for(int i = 0; i < dictEntry.Length; i++)
            {
                Console.WriteLine(dictEntry[i]);
            }
            /*
            dictEntry[0] = "caput - huvud";
            dictEntry[1] = "videre - se";
            dictEntry[2] = "pater - far, pappa";
            dictEntry[3] = "arbor - träd";
            dictEntry[4] = "luna - måne";
            dictEntry[5] = "movere - flytta";
            dictEntry[6] = "urbs - stad";
            */

            Console.WriteLine("Skriv ett ord du vill ha översatt!");
            do
            {
                Console.Write(">");
                command = Console.ReadLine();
                if (command == "svenska")
                {
                    Console.Write("Vilket ord vill du ha översatt: ");
                    string translate = Console.ReadLine();
                    string test = "hej";
                    for(int i = 0; i < dictEntry.Length; i++)
                    {
                        Console.WriteLine(dictEntry[i]);
                    }
                    Console.WriteLine("> '{0}' är '{1}' på svenska!", translate, test);
                }
                else
                {
                    Console.WriteLine(command);
                }
            } while (command != "sluta");
        }
    }
}
