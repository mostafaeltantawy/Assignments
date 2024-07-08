namespace Common6
{
    public class TypeA
    {
       private int X; // Accessible within Its Sope Only 
        internal int Y; 
        public int Z;

         void Print()
        {
            Console.WriteLine(X);
        }

    }
}
