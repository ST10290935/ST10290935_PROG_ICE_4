using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Quantity
{
    internal class ideas


    {

        public int quantity;
        public int originalQuan;
        public ArrayList stuffs = new ArrayList();
        public ArrayList stuffs2 = new ArrayList();

        public void Quans() {
            Console.WriteLine("enter a value");
            quantity = Convert.ToInt32(Console.ReadLine());
            originalQuan = quantity;
            stuffs.Add(quantity);
            
            stuffs2.Add(originalQuan);

        }
        public void Scale() {
           
            Console.WriteLine("select a scale option:\n1)0.5 \n2)2 \n3)3");
            int choose = Convert.ToInt32(Console.ReadLine());
            switch (choose) {
                case 1:
                    double scale = quantity * 0.5;
                    Console.WriteLine("This is the scaled amount: " + scale);
                    break;
                    case 2:
                    double scale1 = quantity * 2;
                    Console.WriteLine("This is the scaled amount: " + scale1);
                    break;
                    case 3:
                    double scale3 = quantity * 3;
                    Console.WriteLine("This is the scaled amount: " + scale3);
                    break;

            }
        }
        public void Revert()
        {
            int revert = originalQuan;
            Console.WriteLine("this is the orignal value entered: " + originalQuan);
        }
        public void Crazy() {
           

            for (int i = 1; i <= quantity; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(quantity);
                }
                Console.WriteLine();
            }

        }
    }
}
