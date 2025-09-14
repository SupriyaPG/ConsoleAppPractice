using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practiceApp
{
    internal class FileOperations
    {
        String path = "d:\\hello.txt"; //D:\

        internal void createFile()
        {
            
            if (File.Exists(path))
            { 
                File.Delete(path);
                //Console.WriteLine("File is already exist.");
            }
          
            FileStream fs= File.Create(path);
            fs.Close();
            Console.WriteLine("File created.");
                
        }

        internal void AddContentInFile()
        {
            //File.WriteAllText(path,"Welcome in file handling concept");
            StreamWriter sr=new StreamWriter(path);

            if (File.Exists(path))
            {
                sr.WriteLine("Welcome in file handling concept.");
                sr.Close();
                Console.WriteLine("Content Added.");
            }
            else
            { sr.WriteLine("File not exist."); }
        }

        internal void appendContentInFile()
        {
            try
            {
                //File.WriteAllText(path,"Welcome in file handling concept");
                StreamWriter sr = new StreamWriter(path, true);

                if (File.Exists(path))
                {
                    sr.WriteLine("Append Mode.");
                    sr.Close();
                    Console.WriteLine("Content updated.");
                }
                else
                { sr.WriteLine("File not exist."); }
            }
            catch(Exception e) { Console.WriteLine(e.ToString()); }
        }

        internal void readFileContent()
        {
            try
            {
                StreamReader sr = new StreamReader(path);
                String data = sr.ReadToEnd();
                sr.Close();
                Console.WriteLine(data);
            }catch (Exception ex) { Console.WriteLine(ex.ToString()); }
        }

        internal void deleteFile()
        {
            try
            {
                File.Delete(path);
                Console.WriteLine("File deleted.");
            }catch(Exception e)
            { Console.WriteLine(e.ToString()); }
            
        }
        
    }
}
