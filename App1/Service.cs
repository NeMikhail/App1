using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1
{
    class Service
    {
        #region Print
        public static void Print(string output, int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(output);
        }

        public static void PrintLine(string output, int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine(output);
        }

        public static void PrintCenter(string output)
        {
            int x;
            if (output.Length / 2 < Console.WindowWidth / 2)
                x = Console.WindowWidth / 2 - (output.Length / 2);
            else
                x = 0;
            Console.SetCursorPosition(x, Console.CursorTop);
            Console.WriteLine(output);
            x = 0;
        }

        public static void PrintArray(string[] output)
        {
            for (int i = 0; i < output.Length; i++)
            {
                Console.Write($" {i} : {output[i]} ");
            }
            Console.WriteLine("");
        }
        #endregion

        #region File
        public static void PrintToFile(string path, string filename, string output)
        {
            // Проверка наличия каталога для файла
            DirectoryInfo dirInfo = new DirectoryInfo(path);
            if (!dirInfo.Exists)
            {
                dirInfo.Create();
            }
            // Запись в файл
            using (StreamWriter sw = new StreamWriter($"{path}{filename}.txt", true, System.Text.Encoding.Default))
            {
                sw.WriteLine(output);
            }
        }

        public static string ReadFromFile(string path, string filename)
        {
            // Чтение из файла
            using (StreamReader sr = new StreamReader(path + filename + ".txt"))
            {
                string output = sr.ReadToEnd();
                return output;
            }
        }

        #endregion

        #region array
        public static string[] Splitter(string input, char[] chars)
        {
            // Разбиение строки по массиву символов
            string[] output;
            output = input.Split(chars);
            return output;
        }

        public static string Uniter(string[] input)
        {
            string output = "";
            for (int i = 0; i < input.Length; i++)
            {
                output = output + input[i];
            }
            return output;
        }
        #endregion


        public static void Pause()
        {
            Console.Write("Press enter to continue...");
            Console.ReadLine();
        }
    }
}
