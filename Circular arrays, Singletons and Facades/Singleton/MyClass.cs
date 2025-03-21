namespace DesignPatterns
{
    public class MyClass
    {
        private int _value;
        private static MyClass _instance;

        // Private constructor to prevent external instantiation
        private MyClass(int value)
        {
            _value = value;
        }

        // Public method to get the instance (with lazy initialization)
        public static MyClass GetInstance(int value)
        {
            if (_instance == null) // Ensure only one instance is created
            {
                _instance = new MyClass(value);
            }
            return _instance;
        }

        public void PrintValue()
        {
            Console.WriteLine("Value= " + _value);
        }
    }
}