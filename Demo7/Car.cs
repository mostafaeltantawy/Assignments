namespace Demo7
{
    internal class Car
    {

        #region Properties
        public int Id { get; set; }
        public string Model { get; set; }
        public double Speed { get; set; }

        public override string ToString()
        {
            return $"Id : {Id}\nModel : {Model}\nSpeed : {Speed} ";
        }
        #endregion

        #region Constructor

        public Car()
        {

        }

        public Car(int id, string model, double speed)
        {
            Id = id;
            Model = model;
            Speed = speed;
        }

        public Car(int id, string model) : this(id, model, 190)
        {

        }

        public Car(int id) : this(id, "Audi", 200)
        {


        }

        #endregion
    }
}
