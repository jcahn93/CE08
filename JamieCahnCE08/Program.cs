using System;
using System.IO;
using System.Collections.Generic;
using System.Collections;

namespace JamieCahnCE08
{
    class Program
    {
        List<string[]> Records = new List<string[]>();
        List<string[]> RealRecords = new List<string[]>();

        static void Main(string[] args)
        {
            Program instance = new Program();
            bool running = true;
            List<string> dataList = new List<string>();
            Dictionary<string, string[]> dictionaryDataList = new Dictionary<string, string[]>();

            Dictionary<string, List<string>> Data;


            while (running)
            {
                Console.Clear();
                Console.WriteLine("Menu");
                Console.WriteLine("Which file would you like to load: ");
                Console.WriteLine("1. DataFile1");
                Console.WriteLine("2. DataFile2");
                Console.WriteLine("3. DataFile3");
                Console.WriteLine("4. Exit");
                Console.Write("Please Select a datafile to load: ");
                string input = Console.ReadLine().ToLower();

               




                switch (input)
                {
                    case "1":
                    case "datafile1":
                    case "data file 1":
                        {
                            instance.MakeList(dataList);
                            instance.LoadFileOne(dictionaryDataList, dataList);
                            instance.PrintRecords();
                            Utility.PauseBeforeContinuing();

                        }
                        break;
                    case "2":
                    case "datafile2":
                    case "data file 2":
                        {
                            instance.MakeList(dataList);
                            instance.LoadFileTwo(dictionaryDataList, dataList);
                            instance.PrintRecords();
                            Utility.PauseBeforeContinuing();
                        }
                        break;
                    case "3":
                    case "datafile3":
                    case "data file 3":
                        {
                            instance.MakeList(dataList);
                            instance.LoadFileThree(dictionaryDataList, dataList);
                            instance.PrintRecords();
                            Utility.PauseBeforeContinuing();
                        }
                        break;
                    case "4":
                    case "exit":
                        {
                            running = false;
                        }
                        break;
                    default:
                        {
                            Utility.Invalid();
                        }
                        break;
                }
            }
        }

        private List<string> MakeList(List<string> dataList)
        {

            using (StreamReader sr = new StreamReader(File.OpenRead("DataFieldsLayout.txt")))
            {

                string fileName = sr.ReadToEnd();
                string[] tmp = fileName.Split('\n');
                for (int i = 0; i < tmp.Length - 1; i++)
                {
                    dataList.Add(tmp[i]);
                }
            }
            return dataList;
        }


        private void LoadFileOne(Dictionary<string, string[]> dictionaryDataList, List<string> dataList)
        {
            using (StreamReader sr = new StreamReader(File.OpenRead("DataFile1.txt")))
            {
                dictionaryDataList.Clear();
                Records.Clear();
                RealRecords.Clear();

                sr.ReadLine();
                string fileName = sr.ReadToEnd();
                string[] tmp = fileName.Split('|');

                int yy = 0;
                int index;
                for (int i = 0; i < 100; i++)
                {
                    Records.Add(new string[149]);
                }
                for (int i = 0; i <149; i++)
                {
                    RealRecords.Add(new string[100]);

                }
               
                for (int i = 0; i < 100; i++)
                {

                    for (int j = 0; j < 149; j++)
                    {
                    Records[i][j] = tmp[yy];
                    yy++;

                    }
                }
                int realIndex;

                for (int i = 0; i < Records.Count; i++)
                {
                    for (int j = 0; j < 149; j++)
                    {
                    RealRecords[j][i] = Records[i][j];

                    }
                }

                



            }
        }

        private void LoadFileTwo(Dictionary<string, string[]> dictionaryDataList, List<string> dataList)
        {
            using (StreamReader sr = new StreamReader(File.OpenRead("DataFile2.txt")))
            {
                dictionaryDataList.Clear();
                Records.Clear();
                RealRecords.Clear();

                sr.ReadLine();
                string fileName = sr.ReadToEnd();
                string[] tmp = fileName.Split('|');

                int yy = 0;
                int index;
                for (int i = 0; i < 100; i++)
                {
                    Records.Add(new string[149]);
                }
                for (int i = 0; i < 149; i++)
                {
                    RealRecords.Add(new string[100]);

                }

                for (int i = 0; i < 100; i++)
                {

                    for (int j = 0; j < 149; j++)
                    {
                        Records[i][j] = tmp[yy];
                        yy++;

                    }
                }
                int realIndex;

                for (int i = 0; i < Records.Count; i++)
                {
                    for (int j = 0; j < 149; j++)
                    {
                        RealRecords[j][i] = Records[i][j];

                    }
                }




            }
        }

        private void LoadFileThree(Dictionary<string, string[]> dictionaryDataList, List<string> dataList)
        {
            using (StreamReader sr = new StreamReader(File.OpenRead("DataFile3.txt")))
            {
                dictionaryDataList.Clear();
                                Records.Clear();
                RealRecords.Clear();

                sr.ReadLine();
                string fileName = sr.ReadToEnd();
                string[] tmp = fileName.Split('|');

                int yy = 0;
                int index;
                for (int i = 0; i < 100; i++)
                {
                    Records.Add(new string[149]);
                }
                for (int i = 0; i < 149; i++)
                {
                    RealRecords.Add(new string[100]);

                }

                for (int i = 0; i < 100; i++)
                {

                    for (int j = 0; j < 149; j++)
                    {
                        Records[i][j] = tmp[yy];
                        yy++;

                    }
                }
                int realIndex;

                for (int i = 0; i < Records.Count; i++)
                {
                    for (int j = 0; j < 149; j++)
                    {
                        RealRecords[j][i] = Records[i][j];

                    }
                }



            }
        }

        public void PrintRecords()
        {
            Console.Clear();

            for (int i = 0; i < RealRecords.Count; i++)
            {
                for (int j = 0; j < 100; j++)
                {
                    Console.WriteLine(RealRecords[i][j]);
                }
            }

            Console.Read();
        }

        private void ConvertRecordsToJSON()
        {
            Console.Clear();

           /* using (StreamWriter sw = new StreamWriter("datafile.json"))
            {
                for (int i = 0; i < RealRecords.Count; i++)
                {
                    for (int j = 0; j < 100; j++)
                    {
                        sw.WriteLine(RealRecords[i][j]);
                    }
                }

                bool running = true;
                while (running)
                {
                    using (StreamReader sr = new StreamReader())
                }
            */

            }





        }







    }
}
