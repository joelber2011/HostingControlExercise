using HostingControlExercise.Entities;

namespace HostingControlExercise
{
    public class Program
    {
        static void Main()
        {
            Console.Write("Room number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            Console.Write("Check-in date (dd/MM/yyyy): ");
            DateTime checkIn = Convert.ToDateTime(Console.ReadLine());

            Console.Write("Check-out date (dd/MM/yyyy):");
            DateTime checkOut = Convert.ToDateTime(Console.ReadLine());

            Reservation reservation = new Reservation(number, checkIn, checkOut);


        }
    }
}