using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace whatsapp
{
    public void client(int x, int phone)
    {
        if (x == 1)
        {
            phone = Console.Read();
        }

    }


        static void Main(string[] args)
        {
        Console.WriteLine("click 1 to add a conract");
        Console.WriteLine("click 2 to edit a contact");
        Console.WriteLine("click 33 to type a message");
        Console.WriteLine("click 4 to see the clients");
        int x = Console.Read();



        List<contacts> k = new List<contacts>();
        k.Add(new contacts());
        k[0].phone = Console.Read();


        }
 
}
