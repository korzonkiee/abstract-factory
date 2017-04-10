using GraphicsAPI.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicsAPI.Implementations
{
    public class DirectXTexture : ITexture
    {
        private string content;
        public string Content
        {
            set
            {
                content = value;
            }
        }

        public void SetActive()
        {
            Console.WriteLine($"DirectX texture from file {content} activated.");
        }
    }
}
