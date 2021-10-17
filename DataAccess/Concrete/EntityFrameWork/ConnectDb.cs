using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFrameWork
{
   public class ConnectDb
   {
       public static string path = Environment.CurrentDirectory+"/Adress.txt";
       public static string Adress = System.IO.File.ReadAllText(path);
   }
}
