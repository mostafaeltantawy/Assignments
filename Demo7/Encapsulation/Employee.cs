namespace Demo7.Encapsulation
{
    internal struct Employee
    {
        #region Attributes
        public int Id;
        private string? Name;
        private decimal salary;


        #endregion

        //Encapsulation => Seperate Date definition from its Use by using [Getter Setter , Attributes]
        // A. All attributes be private 
        // B. [Getter Setter] - [Property] 

        #region 1. Appling Encapsulation Using Getter and Setter 
        // Getter 
        public string? GetName() { return Name; }

        //Setter 

        public void SetName(string? _name)
        {
            Name = _name?.Length > 5 ? _name.Substring(0, 5) : _name;
        }

        #endregion


        #region 2. Appling Encapsulation Using property 
        // Property [Full Property , Automatic Property , Indexer]

        public decimal Salary
        {
            get
            {
                return salary;

            }

            set
            {
                salary = value < 3000 ? 3000 : value;
            }
        }


        //Full property 
        //private int age; 

        //public int Age
        //{
        //    get { return age; }
        //    set { age = value; }
        //}

        //Automatic property 
        // Coopi;er will Generate Hidden Private Atriibute [Backing field]

        public int Age { get; set; }

        //private decimal deduction; // derive attribute

        public decimal Deduction // Readonly
        {
            get
            {
                return Salary * 0.2M;

            }

        }





        #endregion

        #region Constructor
        public Employee(int id, string? name, decimal salary, int age)
        {
            Id = id;
            Name = name;
            this.salary = salary;
            Age = age;
        }

        #region Methods
        public override string ToString()
        {
            return $"Id = {Id}\nName = {Name}\nSalary  = {salary}\nAge = {Age}";
        }
        #endregion
        #endregion
    }
}
