// See https://aka.ms/new-console-template for more information
using static System.Runtime.InteropServices.JavaScript.JSType;

// Define a bool variable to verify the input validity of the current data.
bool isValidInput = false;

while (!isValidInput)
{
    try
    {
        // Code to be executed when correct data is entered. Calculating the square of this number.
        Console.Write("Lutfen Bir Sayi Giriniz: ");
        int userNumber = Convert.ToInt32(Console.ReadLine());
        Console.Write(Math.Pow(userNumber, 2));
        isValidInput = true;
    }
    // Code to be executed when incorrect data is entered
    catch (Exception ex)
    {
        Console.WriteLine("Hatali Veri Girdiniz.");
    }
}







//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Xml;

//namespace GenericYapilarWeek5.Exceptıon_Management
//{
//    public class ExceptionManager
//    {
//        public static void Main(string[] args)
//        {
//            bool isValidInput = false;

//            while (!isValidInput)
//            {
//                try
//                {
//                    Console.WriteLine("Sayi Girin:");
//                    string input = Console.ReadLine();
//                    int number = Convert.ToInt32(input);

//                    isValidInput = true;


//                }

//                catch (Exception ex)
//                {
//                    Console.WriteLine("Hatali veri Girdiniz.");
//                }

//                finally
//                {
//                    Console.WriteLine("Islem tamamlandi");
//                }
//            }

//        }

//    }
//}


//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Security.Cryptography.X509Certificates;
//using System.Text;
//using System.Threading.Tasks;

//namespace GenericYapilarWeek5.Exception_Management
//{

//    public class PrivateException
//    {
//        public void SetAge(int age)
//        {
//            if (age < 0)
//            {
//                //throw new Exception("Hata");
//                throw new InvalidAgeExeption("Yas Negatif girilemez");
//            }

//            throw new Exception("Genel bir hata olustu");
//        }
//    }

//    public class InvalidAgeExeption : Exception
//    {
//        public InvalidAgeExeption(string message) : base(message)
//        { }
//    }

//    class Program1
//    {
//        public static void Main(string[] args)
//        {
//            PrivateException user = new PrivateException();

//            try
//            {
//                user.SetAge(-19);
//            }
//            catch (InvalidAgeExeption ex)
//            {
//                Console.WriteLine(ex.Message);
//            }
//            catch (Exception ex)
//            {
//                Console.WriteLine("Genel bir hata alindi");
//            }
//        }

//    }
//}




