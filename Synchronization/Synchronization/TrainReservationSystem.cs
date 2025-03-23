namespace Synchronization;

public class TrainReservationSystem
{
    private int totalSeats;
    private int availableSeats;
    private readonly object locker = new object();

    public TrainReservationSystem()
    {
        totalSeats = 10;
        availableSeats = totalSeats;
    }

    public bool BookSeat(int seatsToBook)
    {
        lock (locker)
        {
            if (seatsToBook <= availableSeats)
            {
                availableSeats -= seatsToBook;
                Console.WriteLine("Available seats: " + availableSeats);
                Console.WriteLine("Number of seats booked: " + seatsToBook);
                return true;
            }
            else
            {
                Console.WriteLine("There are not enough available seats: " + availableSeats);
                return false;
            }
        }
    }

    public bool CancelSeat(int seatsToCancel)
    {
        lock (locker)
        {
            int bookedSeats = totalSeats - availableSeats;

            if (seatsToCancel <= bookedSeats && seatsToCancel > 0)
            {
                availableSeats += seatsToCancel;
                Console.WriteLine("The number of cancelled seats: " + seatsToCancel + " | Available seats: " + availableSeats);
                return true;
            }
            else
            {
                Console.WriteLine("Cannot cancel " + seatsToCancel + " seat(s). Booked seats: " + bookedSeats);
                return false;
            }
        }
    }

    public int GetAvailableSeats()
    {
        lock (locker)
        {
            return availableSeats;
        }
    }
}