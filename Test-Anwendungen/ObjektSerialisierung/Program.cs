using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace ObjektSerialisierung
{
    class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.SerializeNow();
            program.DeSerializeNow();
        }

        public void SerializeNow() {
            ClassToSerialize c = new ClassToSerialize();
            File f = new File("temp.dat");
            Stream s = f.Open(FileMode.Create);
            BinaryFormatter b = new BinaryFormatter();
            b.Serialize(s, c);
            s.Close();
        }

        public void DeSerializeNow() {
            ClassToSerialize c = new ClassToSerialize();
            File f = new File("temp.dat");
            Stream s = f.Open(FileMode.Open);
            BinaryFormatter b = new BinaryFormatter();
            c = (ClassToSerialize) b.Deserialize(s);
            Console.WriteLine(c.name);
            s.Close();
        }
    }
}
