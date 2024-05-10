namespace Quantity
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ideas idk = new ideas();
            while (true)
            {
                Console.WriteLine("select the following:\n1)add number \n2)Scale number \n3)Revert numver \n4)Click For Fun\n5)Exit");
                int choice = Convert.ToInt32(Console.ReadLine());
               
                switch (choice) {
                    case 1:
                        idk.Quans();
                        break;
                        case 2:
                        idk.Scale();
                        break;
                        case 3:
                        idk.Revert();
                            break;
                    case 4:
                        idk.Crazy();
                        break;
                        case 5:
                        Environment.Exit(0);
                            break;
                        //default:
                        //Console.WriteLine("invalid input");
                        //break;

                }
                

            }
        }
    }
}
