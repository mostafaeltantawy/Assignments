﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoADV04.Fifa
{
    internal class Ball
    {
        public int Id { get; set; }

		private Location location;

		public Location Location
		{
			get { return location; }
			set
			{
				if(value.Equals(location))
				{
                    location = value;
                    // Notify subscriber
                    BallLocationChanged?.Invoke();
                }
			 
			}
		}

		public event Action? BallLocationChanged;

        public override string ToString()
        {
			return $"Id : {Id} , Location : {Location}";
        }
    }


}
