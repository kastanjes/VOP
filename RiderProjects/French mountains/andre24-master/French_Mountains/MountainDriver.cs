namespace French_Mountains;

public class MountainDriver
{
    public static void Main(string[] args)
    {
        // For testing the Mountain class
        
        // NB: \u00B0 is unicode for the degree-symbol
        // Exercise A
        // Mountain m = new Mountain("Mont Ventoux", 1909, 1148, "44\u00B010'26\"", "05\u00B016'42\"", "Alps");
        // Console.WriteLine(m);
        
        // Exercise B
        // Mountain[] mountainArray = new Mountain[4];
        // mountainArray[0] = new Mountain("Pic du Midi d'Ossau", 2886, 1092, "42\u00B048'22\"", "-00\u00B025'05\"", "Pyrenees");
        // mountainArray[1] = new Mountain("Pica d'Estats", 3143, 1281, "42\u00B042'43\"", "00\u00B057'23\"", "Pyrenees");
        // mountainArray[2] = new Mountain("Pic de Bure", 2709, 1268, "44\u00B037'38\"", "05\u00B056'07\"", "Alps");
        // mountainArray[3] = new Mountain("Mont Chaberton", 3131, 1281, "44\u00B057'53\"", "06\u00B045'06\"", "Alps");
        //
        // Console.WriteLine("Unsorted: ");
        // Array.ForEach(mountainArray, Console.WriteLine);
        //
        // Console.WriteLine("\nSorted: ");
        // Array.Sort(mountainArray);
        // Array.ForEach(mountainArray, Console.WriteLine);
        
        // Exercise C
        // Console.WriteLine("\nSet: ");
        // MountainSet mSet = new MountainSet();
        // mSet.LoadMountains();
        // mSet.PrintMountains();

        // Exercise D
        // Console.WriteLine("\nSorted by range: ");
        // ISet<Mountain> set = mSet.SortByRange(new MountainRangeComparer());
        // Console.WriteLine("[" + string.Join("\n, ", set) + "]");
    }
}