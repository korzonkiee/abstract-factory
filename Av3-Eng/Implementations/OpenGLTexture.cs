using GraphicsAPI.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicsAPI.Implementations
{
    public class OpenGLTexture : ITexture
    {
        private string content;
        public string Content
        {
            set
            {
                content = $"{value}.superFormat";
            }
        }

        public void SetActive()
        {
            Console.WriteLine($"OpenGL texture from file {content} activated");
        }
    }
}
