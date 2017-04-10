using GraphicsAPI.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicsAPI.Implementations
{
    public class DirectXRenderer : IRenderer
    {
        private I3DModel model;
        public I3DModel Model
        {
            set
            {
                model = value;
            }
        }

        private ITexture texture;
        public ITexture Texture
        {
            set
            {
                texture = value;
            }
        }

        public void Render(bool advanced)
        {
            Console.WriteLine("Before activating");
            model.SetActive();
            texture.SetActive();
            Console.WriteLine("DirectX is rendering model...");
        }
    }
}
