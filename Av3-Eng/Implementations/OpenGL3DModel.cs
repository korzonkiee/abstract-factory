using GraphicsAPI.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicsAPI.Implementations
{
    public class OpenGL3DModel : I3DModel
    {
        private Vector3 position;
        public Vector3 Position
        {
            set
            {
                value.Y = value.Y * -1;
                position = value;
            }
        }

        public void SetActive()
        {
            Console.WriteLine($"OpenGL model at position {position.X}, {position.Y}, {position.Z} set active");
        }
    }
}
