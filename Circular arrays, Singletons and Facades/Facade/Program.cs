// See https://aka.ms/new-console-template for more information

using Facade;

class Program
{
    public static void Main(string[] args)
    {
        CarFacade carFacade = new CarFacade();
        carFacade.Brake();
    }
}
