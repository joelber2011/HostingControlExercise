using Course.Entities;
using HostingControlExercise.Entities.Exceptions;

namespace Course
{
    class Program
    {
        static void Main()
        {

            try
            {
                Console.Write("Room number: ");
                int number = Convert.ToInt32(Console.ReadLine());
                Console.Write("Check-in date (dd/MM/yyyy): ");
                DateTime checkIn = Convert.ToDateTime(Console.ReadLine());
                Console.Write("Check-out date (dd/MM/yyyy): ");
                DateTime checkOut = Convert.ToDateTime(Console.ReadLine());

                Reservation reservation = new (number, checkIn, checkOut);
                Console.WriteLine("Reservation: " + reservation);

                Console.WriteLine();
                Console.WriteLine("Enter data to update the reservation:");
                Console.Write("Check-in date (dd/MM/yyyy): ");
                checkIn = Convert.ToDateTime(Console.ReadLine());
                Console.Write("Check-out date (dd/MM/yyyy): ");
                checkOut = Convert.ToDateTime(Console.ReadLine());

                reservation.UpdateDates(checkIn, checkOut);
                Console.WriteLine("Reservation: " + reservation);
            }
            catch (FormatException e)
            {
                Console.WriteLine("Error in format: " + e.Message);
            }
            catch (DomainException e)
            {
                Console.WriteLine("Error in reservation: " + e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Unexpected error: " + e.Message);
            }
        }
    }
}