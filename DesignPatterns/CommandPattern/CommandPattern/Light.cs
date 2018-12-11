﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern
{
    public class Light
    {
        private readonly string _name;

        public Light(string name = "")
        {
            _name = name;
        }

        public void On()
        {
            Console.WriteLine($"{_name} light is on");
        }

        public void Off()
        {
            Console.WriteLine($"{_name} light is off");
        }
    }
}
