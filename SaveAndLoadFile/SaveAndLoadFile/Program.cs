using System;
using System.IO;

namespace SaveAndLoadFile
{
    class Program
    {
        static void Main(string[] args)
        {
            loadFile();

            saveFile();

            Console.ReadLine();
        }

        public static void loadFile()
        {
            String line;

            try
            {
                // 讀此路徑檔案
                StreamReader sr = new StreamReader(".\\test.txt");
                // 讀第一行資料
                line = sr.ReadLine();
                // 讀檔到最後一行
                while (line != null)
                {
                    //Console.WriteLine(line);
                    // 讀下一行
                    line = sr.ReadLine();
                }
                // 關閉檔案
                sr.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                //Console.WriteLine("Executing finally block.");
            }
        }

        public static void saveFile()
        {
            string path = ".\\file.txt";
            string Text = "Hello and Welcome";
            using (StreamWriter writetext = new StreamWriter(path))
            {
                writetext.WriteLine(Text);

                Console.WriteLine("寫檔成功") ;
            }

            /* try
             {
                 //Pass the filepath and filename to the StreamWriter Constructor
                 StreamWriter sw = new StreamWriter(".\\file.txt");
                 //Write a line of text
                 sw.WriteLine("Hello World!!");
                 //Write a second line of text
                 sw.WriteLine("From the StreamWriter class");
                 //Close the file
                 sw.Close();
             }
             catch (Exception e)
             {
                 Console.WriteLine("Exception: " + e.Message);
             }
             finally
             {
                 Console.WriteLine("Executing finally block.");
             }*/
        }
    }
}
