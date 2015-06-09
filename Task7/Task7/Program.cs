using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7
{
    class IntArray
    {
                private    int[] data;
    
        public IntArray(int size)
        {
            data = new int[size];
        }
        
        public int Length
        {
            get
            {
                return data.Length;
            }
        }

        public int MaxElement
        {
            get
            {
                return data.Max();
            }
        }

        public int MinElement
        {
            get
            {
                return data.Min();
            }
        }

        public int this[int index]
        {
            get
            {
                return data[index];
            }
        
            set
            {
                data[index] = value;
            }
        }
            
        public static IntArray operator++(IntArray array)
        {
            for(int i = 0; i < array.Length; ++i)
                --array.data[i];
        
            return array;
        }
    
        public static IntArray operator--(IntArray array)
        {
            for(int i = 0; i < array.Length; ++i)
                ++array.data[i];
        
            return array;
        }            
        
        public static bool operator!(IntArray array)
        {
            for(int i = 1; i < array.Length; ++i)
                if(array.data[i-1] > array.data[i])
                    return true;
            
            return false;
        }
        
        public static IntArray operator*(IntArray array, int scalar)
        {
            IntArray resArray = new IntArray(array.Length);
            array.data.CopyTo(resArray.data, 0);
            
            for(int i = 0; i < resArray.Length; ++i)
                resArray.data[i]*= scalar;
            
            return resArray;
        }
        
        public static explicit operator int[](IntArray array)
        {
            return array.data;
        }
        
        public static void setupArray(IntArray array){
                    IntArray resArray = new IntArray(array.Length);
            array.data.CopyTo(resArray.data, 0);
        for(int i = 0;i<resArray.Length;i++)
            {
                resArray[i] = Convert.ToInt32(Console.ReadLine());

        }
           
    }

        public static explicit operator IntArray(int[] array)
        {
            IntArray resArray = new IntArray(array.Length);
            array.CopyTo(resArray.data, 0);
            
            return resArray;
        }
 
        
        public static void WriteToConsole(IntArray array, int width)
        {
            for(int i = 0; i < array.Length; ++i)
                Console.Write("{0," + width + "}", array.data[i]);                    
        }
    }

 
class Program
{    
    public static void Main()
    {
        Random rand = new Random();
        Task7.IntArray a = new Task7.IntArray(10);
        
        for(int i = 0; i < a.Length; ++i)        
            a[i] = rand.Next(1, 10);            
        
        const int OUTPUT_WIDTH = 4;
        
        Console.WriteLine("Исходный массив:");
        Task7.IntArray.WriteToConsole(a, OUTPUT_WIDTH);        
        
        Console.WriteLine("\nУпорядоченность по возрастанию: {0}", (!a)? "нет\n" : "да\n");        
                    
        ++a;
        Console.WriteLine("operator--:");
        Task7.IntArray.WriteToConsole(a, OUTPUT_WIDTH);
        Console.WriteLine("\n");        
 
        --a;
        Console.WriteLine("operator++:");
        Task7.IntArray.WriteToConsole(a, OUTPUT_WIDTH);
        Console.WriteLine("\n");                
        
        a*= 2;
        Console.WriteLine("operator*:");
        Task7.IntArray.WriteToConsole(a, OUTPUT_WIDTH);
        Console.WriteLine("\n");
                    
        Array.Sort((int[])a);
        Console.WriteLine("IntArray -> int[] + Array.Sort:");
        Task7.IntArray.WriteToConsole(a, OUTPUT_WIDTH);        
                
        Console.WriteLine("\nУпорядоченность по возрастанию: {0}", (!a)? "нет\n" : "да\n");        
                        
        int[] t = {1,2,3,4,5};
        a = (Task7.IntArray)t;
        Console.WriteLine("int[]{1,2,3,4,5} -> IntArray:");
        Task7.IntArray.WriteToConsole(a, OUTPUT_WIDTH);    
        Console.WriteLine("\n");
        
    }
    }
}
