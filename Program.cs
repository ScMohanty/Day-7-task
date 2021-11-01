using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlipKart
{
    class User
    {
        string email;
        string password;
        string address;
        long mobile;

        public string Email { get => email; set => email = value; }
        public string Password { get => password; set => password = value; }
        public string Address { get => address; set => address = value; }
        public long Mobile { get => mobile; set => mobile = value; }
    }
    class Product
    {
        string Id;
        string name;
        string category;
        int price;

        public string Id1 { get => Id; set => Id = value; }
        public string Name { get => name; set => name = value; }

        public int Price { get => price; set => price = value; }
        public string Category1 { get => category; set => category = value; }
    }
    class MyBill
    {
        public static void Main(string[] args)
        {
         
            object[] userDetails = new object[4];
            object[] productDetails;
            int userNo;
            int productNo;
            Console.WriteLine("ENTER THE NO OF USERS");
            userNo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ENTER NO OF PRODUCT");
            productNo = Convert.ToInt32(Console.ReadLine());
            
            User u = new User();
            Product p = new Product();

            for (int i = 0; i < userNo; i++)
            {
                productDetails = new object[productNo * 4];
                int count = 0;
                int k = 0;
                Console.WriteLine("ENTER USER DETAILS PLEASE");
                Console.WriteLine("enter email");
                u.Email = Console.ReadLine();
                Console.WriteLine("enter password");
                u.Password = Console.ReadLine();
                Console.WriteLine("enter address");
                u.Address = Console.ReadLine();
                Console.WriteLine("enter mobile");
                u.Mobile = Convert.ToInt64(Console.ReadLine());
                for (int j = 0; j < productNo; j++)
                {

                    Console.WriteLine("ENTER PRODUCT DETAILS");
                    Console.WriteLine("enter id");
                    count++;
                    p.Id1 = Console.ReadLine();
                    Console.WriteLine("enter name");
                    count++;
                    p.Name = Console.ReadLine();
                    Console.WriteLine("enter category");
                    count++;
                    p.Category1 = Console.ReadLine();
                    Console.WriteLine("enter price");
                    count++;
                    p.Price = Convert.ToInt32(Console.ReadLine());

                    userDetails[0] = u.Email;
                    userDetails[1] = u.Password;
                    userDetails[2] = u.Address;

                    userDetails[3] = u.Mobile;
                    while (k < count)
                    {
                        productDetails[k] = p.Id1;
                        k++;
                        productDetails[k] = p.Name;
                        k++;
                        productDetails[k] = p.Category1;
                        k++;
                        productDetails[k] = p.Price;
                        k++;
                    }

                }
                Console.WriteLine("USER DETAILS ARE");
                foreach (var ch in userDetails)
                {

                    Console.WriteLine(ch);
                }
                Console.WriteLine("PRODUCT DETAILS ARE");
                foreach (var n in productDetails)
                {

                    Console.WriteLine(n);
                }
            }

           
        }

    }
}