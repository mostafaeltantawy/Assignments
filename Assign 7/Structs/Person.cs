namespace Assign_7.Structs
{
    internal struct Person
    {

        private int age;


        public string Name { get; set; }


        public int Age
        {
            get { return age; }
            set
            {
                if (value > 0)
                {
                    age = value;
                }

            }
        }




        public Person(string _name, int _age)
        {
            Name = _name;
            age = _age > 0 ? _age : 0;

        }

        public override string ToString()
        {
            return $"Name : {Name} , Age : {age}";
        }





    }
}
