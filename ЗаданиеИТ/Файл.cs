using System;
using System.IO;

namespace ЗаданиеИТ
{
    class Файл
    {
        public void Fil()
        {
            string s, Slovo = "";
            string[] tx;
            char[] poiskslov = new char[] { ' ', '\r', '\n', ',', '?', '-' };
            int Strok=0, Simvol=0;
            using (var st=new StreamReader(@"E:\\TestFile.txt", true))
            {
                while ((s = st.ReadLine()) != null)
                {
                    Strok++;
                    Slovo += s + '\n';
                    Simvol += s.Length;
                }
                tx = Slovo.Split(poiskslov);
                Console.WriteLine("Количество строк: "+Strok);
                Console.WriteLine("Количество слов: "+((tx.Length)-1));
                Console.WriteLine("Количество символов: "+Simvol);
            }  
        }  
     }
}

