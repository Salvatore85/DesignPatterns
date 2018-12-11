using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern
{
    public class LightOnCommand : ICommand
    {
        Light _light;

        public LightOnCommand(Light light)
        {
            _light = light;
        }
        public void execute()
        {
            _light.On();
        }
    }
}
