using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace MyGui
{
    public class Stream
    {

        public Stream()
        {
            //********  text file  *************//

            //intiate_TextWriter();
            //intiate_TextReader();


            //********  Binary file  ************//
            intiate_BinaryWriter();
            intiate_BinaryReader();
        }
        //*********************************     text file   ********************************//
        private void intiate_TextWriter()
        {
            //create a stream reader connection
            StreamWriter write = new StreamWriter(@"C:\Users\Osama\Desktop\MyGui\SFiles\Test.txt");

            //write to the file
            write.WriteLine("Osama sufian");

            //close the resource
            write.Close();
            
        }
        
        private void intiate_TextReader()
        {
            StreamReader read = new StreamReader(@"C:\Users\Osama\Desktop\MyGui\SFiles\Test.txt");
            using (read) {
                MessageBox.Show(read.ReadLine());
            }
        }

        //*********************************     Binary file   ********************************//
        private void intiate_BinaryWriter()
        {
            string name = "WorkInBinary.txt";
            //BinaryWriter bwr = new BinaryWriter(name);
        }

        private void intiate_BinaryReader()
        {

        }
    }


    public class streamEx2
    {
        public streamEx2(){
            op();
        }
        private void op() {
            StreamWriter wr = new StreamWriter("Word.txt");
            using (wr) { for (int i = 0; i < 20; i++) {
                    wr.WriteLine(i + 1);
                }
            }

            StreamReader re = new StreamReader("Word.txt");
            using (re)
            {
                
                /*ArrayList rea = new ArrayList();
                for(int i = 0; i < 20; i++)
                {
                    
                }*/
                MessageBox.Show(re.ReadToEnd());
            }
        }
    }
}

