using System;
using System.Collections.Generic;
using System.Text;

namespace ЗаданиеИТ
{
    class Лист
    {
    
        Random ran = new Random();
        public void MetList()
        { 
            List<intstring> lis = new List<intstring>() { };
            for (int i = 0; i < 20; i++)
            {
                lis.Add(new intstring() { x = ran.Next(0, 8), str = "12" });
                Console.WriteLine("x="+lis[i].x +" str="+lis[i].str);
            }
           
           for (int k=0;k< lis.Count; k++)
                for(int l = k+1; l < lis.Count; l++)
                {
                    if (lis[k].x == lis[l].x)
                    {
                        lis.RemoveAt(l);
                        l--;
                    }
                   
                }
            for (int k = 0; k < lis.Count; k++)
                Console.WriteLine("x="+lis[k].x + " str=" + lis[k].str);

        }
    }
    class intstring
    {
        public int x { get; set; }
        public string str { get; set; }
    }
}
