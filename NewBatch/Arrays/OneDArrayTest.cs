using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewBatch.Arrays
{
    internal class OneDArrayTest
    {
        static void Main(string[] args)
        {
            int even = 0, odd=0 ;
            int[] a = { 4, 3, 9, 5, 7, 4, 1, 6 };
            Console.WriteLine("Array elements are: ");
            foreach (int i in a)
            {
                Console.Write(i+"  ");
            }
            Console.WriteLine();
            for(int i=0; i<a.Length; i++)
            {
                if (a[i] % 2 == 0)
                {
                    even++;
                }
                else
                {
                    odd++;
                }
            }
            Console.WriteLine("Number of Even elements in array are: "+even);
            Console.WriteLine("Number of Odd elements in array are: "+odd);
        }
    }

    class Test
    {
        static int mcCartyCounter = 100;
        public static int mcCarthy(int n)
        {
            mcCartyCounter++;
            if (n > 100)
            {
                return n - 10;
            }
            else
            {
                return mcCarthy(n + 11);
            }
        }

        public static void Main(string[] args)
        {
            Console.WriteLine(mcCarthy(100)+" "+mcCartyCounter);
        }
    }

    class MinimumFreqChar
    {
        static void Main(string[] args)
        {
            char[] a = { 'a','b','b','c','c','b' };
            Console.WriteLine(String.Join(" ", a));
            
            for(int i = 0; i<a.Length; i++)
            {
                int count = 1;
                bool isVisited = false;
                for(int k=i-1; k>=0; k--)
                {
                    if (a[i] == a[k])
                    {
                        isVisited = true;
                        break;
                    }
                }
                if (isVisited == false)
                {
                    for(int j=i+1; j<a.Length; j++)
                    {
                        if (a[i] == a[j])
                        {
                            count++;
                        }
                    }
                    
                    Console.WriteLine(a[i]+" "+count);
                }
                
            }
        }
    }

    public class Nib
    {
        private string materialType;
        private int width;

        public string MaterialType { get => materialType; set => materialType = value; }
        public int Width { get => width; set => width = value; }

    }

    public class Refill
    {
        private string inkColor;
        private int length;
        private Nib nb;

        public string InkColor { get => inkColor; set => inkColor = value; }
        public int Length { get => length; set => length = value; }
        public Nib Nb { get => nb; set => nb = value; }
    }

    class Pen
    {
        private  Refill refill;
        private int capLength;
        private string brand;

        public int CapLength { get => capLength; set => capLength = value; }
        public string Brand { get => brand; set => brand = value; }

        static void Main(string[] args)
        {
            Pen p = new Pen();
            p.CapLength = 10;
            p.Brand = "Cello";
            p.refill = new Refill();
            p.refill.InkColor = "Black";
            p.refill.Length = 9;
            Refill rf = new Refill();
            rf.Nb = new Nib();
            rf.Nb.MaterialType = "Steel";
            rf.Nb.Width = 2;

            Console.WriteLine("Cap length = "+p.CapLength+"\nBrand = "+p.Brand+"\nInk Color = "+p.refill.InkColor+"\nLength = "+p.refill.Length+"\nMaterial = "+rf.Nb.MaterialType+"\nWidth = "+rf.Nb.Width);

        }
    }


    class SeparateZeroes
    {
        static void Main(string[] args)
        {
            int temp;
            int[] arr = { 12, 0, 7, 0, 8, 0, 3 };
            Console.WriteLine("Array before separating: \n"+String.Join(" ",arr));

            for(int i=0; i<arr.Length; i++)
            {
                temp = 0;
                for(int j=i+1; j<arr.Length; j++)
                if (arr[i] == 0)
                {
                    temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;  
                }

            }
            Console.WriteLine("Array after separting zeroes: \n"+String.Join(" ", arr));

        }
    }


    class RemoveDuplicate
    {
        static void Main(string[] args)
        {
            int[] a = { 4, 3, 2, 4, 9, 2 };
            Console.WriteLine("Array: \n" + String.Join("  ",a));
            int n = 50;
            for (int i = 0; i < 50; i++)
            {
                for (int j = i +1; j<50; j++)
                {
                    if(a[i] == a[j])
                    {
                        while (j < n)
                        {
                            a[j] = a[j + 1];
                            j++;
                        }
                        --n;
                    }
                    else
                    {
                        continue;
                    }
                }
            }
            Console.WriteLine(String.Join(" ",a));
        }
    }


    class Gear
    {
        private string gearType;

        public Gear(string gearType)
        {
            this.gearType = gearType;
        }
        public void showGear()
        {
            Console.WriteLine("Gear type: "+gearType);
        }
    }
    class SubEngine
    {
        private string subEngineType;

        public SubEngine(string subEngineType)
        {
            this.subEngineType = subEngineType;

        }
        public void showSubEngine()
        {
            Console.WriteLine("Sub Engine Type: "+subEngineType);
        }
    }
    class Engine
    {
        private SubEngine sbe;
        private int engineId;
        private string lastEngineCleanDate;
        
        public Engine(int engineId, string lastEngineCleanDate, SubEngine sbe)
        {
            this.engineId = engineId;
            this.lastEngineCleanDate = lastEngineCleanDate;
            this.sbe = sbe;
        }
        public void showEngine()
        {
            Console.WriteLine("Engine Id: "+engineId+"\nLast Engine Clean Date: "+lastEngineCleanDate);
            sbe.showSubEngine();
        }
        
    }
    class Car
    {
        private Engine eg;
        private Gear gr;
        private int carId;
        private string carColor;

        public Car(int carId, string carColor, Engine eg, Gear gr)
        {
            this.carId = carId; 
            this.carColor = carColor;
            this.eg = eg;
            this.gr = gr;

        }
        void showCar()
        {
            Console.WriteLine("Car Id = "+carId+"\nCar Color: "+carColor);
            eg.showEngine();
            gr.showGear();
        }
        static void Main(string[] args)
        {
            Car c = new Car(6969, "Matt Black", new Engine(763478, "30 June 2022",new SubEngine("Turbo")), new Gear("Manual"));
            c.showCar();


        }
    }


    class WhatOutput
    {
        static void Main(string[] args)
        {
            int []var = new int[10];
            
            for(int i=0; i<10; ++i)
            {
                var[i] = i;
                Console.WriteLine(var[i]+"  ");
                i++;
            }
        }
    }

    class OnlyPerfectSquare
    {
        static void Main(string[] args)
        {
            int[] arr = { 23, 43, 25, 49, 12, 9, 78, 66, 39, 0 };

            Console.WriteLine("Array elements are: "+String.Join(" ",arr));
            Console.WriteLine("Perfect square elements from array are: ");
            for(int i=0; i < arr.Length; i++)
            {
                for(int j=1; j < arr[i]; j++)
                {
                    if(arr[i]%j==0 && arr[i] / j == j)
                    {
                        Console.Write(arr[i]+"  ");
                    }
                }
            }
        }
    }

    class ArrayOutput
    {
        static void Main(string[] args)
        {
            int[] a1, a2;
           // a1 ={ 1,2 3};
           // a2 = new String[a1.Length];
        }
    }

    class ReplaceZeroes
    {
        static void Main(string[] args)
        {
            int[] arr = { 26, 0, 67, 45, 0, 78, 54, 34, 10, 0, 34 };
            Console.WriteLine("Array elements are: " + String.Join("  ", arr));

            for(int i=0; i<arr.Length; i++)
            {
                if (arr[i] == 0)
                {
                    arr[i] = 1;
                }
            }
            Console.WriteLine("Array after replacing zeroes: \n"+String.Join("  ",arr));
        }
    }

    class BuzzFizz
    {
        static void Main(string[] args)
        {
            int count1 = 0, count2 = 0, count3 = 0;
            Console.WriteLine("Numbers from 1 to 50: ");
            for(int i=1; i<=50; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("buzzfizz");
                    count3++;
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("fizz");
                    count2++;
                }
                else if(i%3==0)
                {
                    Console.WriteLine("buzz");
                    count1++;
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
            Console.WriteLine();
            Console.WriteLine("Buzz was printed "+count1+" times");
            Console.WriteLine("Fizz was printed " + count2 + " times");
            Console.WriteLine("BuzzFizz was printed " + count3 + " times");

        }
    }
}
