using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    class DynamicArray
    {
        int[] arr;
        int size;

        public int this[int i]
        {
            get
            {
                try
                {
                
                    if (i > size)
                    {
                        throw new IndexOutOfRangeException();
                    }
                    else
                    {
                        return arr[i];
                    }
              
                } catch (Exception)
                {
                    Console.WriteLine("There is no index "+ i);
                    return 0;
                }
             
            }
            set
            {
                try
                {


                    if (i > size-1)
                    {
                        Console.WriteLine("x");
                        throw new IndexOutOfRangeException();
                    }
                    else
                    {
                        Console.WriteLine(size);
                        arr[i] = value;
                    }


                } catch (Exception)
                {

                    Console.WriteLine(arr.Length + "l");
                    if(arr.Length < i)
                    {

                        Console.WriteLine("xx");
                        Array.Resize(ref arr, arr.Length);
                    }


                    for (int j = size; j <= i-1 ; j++)
                    {
                        arr[j] = -1;
                        size++;
                    }
                    arr[i] = value;
                }
       
            }
        }

        public void display()
        {
            Console.WriteLine("The size of the array is {0}", size);
            for (int i = 0; i < size; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();


        }

     
        public void add(int what)
        {
            Array.Resize(ref arr, arr.Length * 2);
            size++;
            arr[size-1] = what;
        }


        public DynamicArray(int size)
        {
            this.size = size;
            this.arr = new int[this.size];
            
            for(int i = 0; i < this.arr.Length; i++)
            {
                arr[i] = -1;
            }
         
        }
    }
}
