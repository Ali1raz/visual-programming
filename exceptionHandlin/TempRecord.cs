using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exceptionHandlin
{
    internal class TempRecord
    {
        float[] temps = new float[10]
        {
            56.2F, 56.7F,56.5F,56.9F, 56.9F,
            56.8F, 56.4F,56.2F,56.1F,56.3F
        };

        public int Length => temps.Length;
        // indexer decl
        public float this[int index]
        {
            get {
                if (index < 0 || index >= Length) throw new IndexOutOfRangeException($"cannot get {index}, Index out of range!");
                return temps[index];
            }
            set {
                if (index < 0 || index >= Length) throw new IndexOutOfRangeException($"cannot set {index}, Index out of range!");
                temps[index] = value;
            }
        }

        public void DisplayTempRecord()
        {
            Console.WriteLine("temp record:");
            for (int i = 0; i < temps.Length; i++)
            {
                Console.WriteLine($"Element# {i}: {temps[i]}F");
            }
        }
    }
}
