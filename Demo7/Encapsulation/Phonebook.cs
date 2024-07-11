namespace Demo7.Encapsulation
{
    internal struct Phonebook
    {
        #region Attributes
        string[] Names;
        int[] Numbers;
        int size;
        #endregion

        #region Properties 
        public int Size
        {
            get { return size; }
        }

        //Indexer => Is a special property  
        //           1. Named with this keyword
        //           2. Can Take Parameter

        public int this[string name]
        {
            get
            {
                if (Names is not null && Numbers is not null)
                {
                    for (int i = 0; i < size; i++)
                    {
                        if (Names[i] == name)
                        {
                            return Numbers[i];
                        }
                    }
                }
                return -1;
            }

            set
            {

                if (Names is not null && Numbers is not null)
                {
                    for (int i = 0; i < size; i++)
                    {
                        if (Names[i] == name)
                        {
                            Numbers[i] = value;
                            break;
                        }
                    }
                }



            }

        }

        #endregion

        #region Constructor
        public Phonebook(int _size)
        {
            size = _size;
            Names = new string[Size];
            Numbers = new int[Size];

        }

        #endregion

        #region Methods

        //Add new Person Into phonebook

        public void AddPerson(int position, string name, int number)
        {
            if (Numbers is not null && Names is not null)
            {
                if (size > position)
                {
                    Names[position] = name;
                    Numbers[position] = number;
                }

            }

        }
        #endregion

        #region Getter Setter 
        public int GetPersonNumber(string name)
        {
            if (Numbers is not null && Names is not null)
            {
                for (int i = 0; i < size; i++)
                {
                    if (Names[i] == name)
                    {
                        return Numbers[i];
                    }
                }
            }
            return -1;
        }

        //setter 

        public void SetPersonNumber(string name, int number)
        {
            if (Names is not null && Numbers is not null)
            {
                for (int i = 0; i < size; i++)
                {
                    if (Names[i] == name)
                    {
                        Numbers[i] = number;
                        break;

                    }
                }
            }
            #endregion





        }
    }
}
