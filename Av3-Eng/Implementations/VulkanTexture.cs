using GraphicsAPI.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicsAPI.Implementations
{
    public class VulkanTexture : ITexture
    {
        private string content;
        public string Content
        {
            set
            {
                content = Reverse(value);
            }
        }

        public void SetActive()
        {
            Console.WriteLine($"Vulkan texture from file {content} activated");
        }

        private string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
