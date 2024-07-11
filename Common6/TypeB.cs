namespace Common6
{
    internal class TypeB
    {
        public TypeB()
        {
            TypeA typeA = new TypeA();
            //TypeA.X = 10; // Invalid because it is private
            typeA.Y = 1;  // invalid because it is in the same project [Internal]

        }
    }
}
