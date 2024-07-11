using Demo7.Inheritance;

namespace Demo7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Encapsulation
            //Employee employee = new Employee(1, "Mostafa" , 3000 , 23);
            //Console.WriteLine(employee);
            //employee.Id = 20; // set Id directly
            //Console.WriteLine(employee.Id); // get Id directly
            //it may cause problems if i change attributes in the class library
            //employee.Name = "mostafa"; // Invalid
            //Console.WriteLine(employee.Name); //Invalid

            //Console.WriteLine(employee.GetName()); //valid get name using getter 

            //employee.SetName("Ali mohamed"); //valid  Set name using setter 

            //Console.WriteLine(employee);

            //employee.salary = 100; // invalid
            //Console.WriteLine(employee.salary); //invalid

            //employee.Salary = 1000; // Use property  as a setter 
            //Console.WriteLine(employee.Salary); // Use property as a getter 

            //Console.WriteLine(employee);

            //Console.WriteLine(employee.Deduction); 







            #endregion

            #region Indexer 
            //Phonebook Note = new Phonebook(3);
            //Note.AddPerson(0, "Mostafa", 1234);
            //Note.AddPerson(1, "Amr", 12345);
            //Note.AddPerson(2, "Mona", 123456);
            ////int MonaNumber = Note.GetPersonNumber("Mona");
            ////Console.WriteLine(MonaNumber == -1 ? "Person not found" : MonaNumber);

            ////Note.SetPersonNumber("Mona", 88888);

            ////Console.WriteLine(Note.GetPersonNumber("Mona") == -1 ? "Person not found" : Note.GetPersonNumber("Mona"));
            //Console.WriteLine(Note["Mona"]);
            //Note["Mona"] = 999;
            //Console.WriteLine(Note["Mona"]);
            #endregion

            #region Class 
            //Car c1; 
            // c1 = new Car();
            //new => 
            // 1. allocate required bytes at heap 
            // 2. Intialize allocated bytes with default value of datatype
            // 3. Call user defined constructer if exist 
            // 4. Assign refrence c1 to allocated object at heap

            //Car c1 = new Car(10, "BMW", 290);
            //Console.WriteLine(c1);
            //Console.WriteLine("--------------------");
            //Car c2 = new Car(20, "BYD");
            //Console.WriteLine(c2);
            //Console.WriteLine("--------------------");
            //Car c3 = new Car(30);
            //Console.WriteLine(c3);

            #endregion

            Parent p = new Parent(1, 2);
            Console.WriteLine(p);
            Console.WriteLine(p.Product());

            Child c = new Child(3, 4, 5);
            Console.WriteLine(c);
            Console.WriteLine(c.Product());



        }
    }
}
