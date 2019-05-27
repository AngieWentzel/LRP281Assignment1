using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
namespace Assignment1LRP281
{
    class TextFileHandler
    {
        FileStream stream;
        StreamReader reader;

        public TextFileHandler()
        {

        }

        public List<string> ReadFromFile(string file)
        {
            List<string> listToReturn = new List<string>();
            try
            {
                stream = new FileStream(file, FileMode.OpenOrCreate, FileAccess.Read);
                reader = new StreamReader(stream);

                while (!reader.EndOfStream)
                {
                    listToReturn.Add(reader.ReadLine());
                }
            }
            catch (FileNotFoundException e)
            {

                MessageBox.Show(e.Message);
            }
            catch (DirectoryNotFoundException e)
            {

                MessageBox.Show(e.Message);
            }
            catch (IOException e)
            {

                MessageBox.Show(e.Message);
            }


            reader.Close();
            stream.Close();

            return listToReturn;
        }
    }
}
