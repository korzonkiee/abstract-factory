using GraphicsAPI.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicsAPI.Implementations
{
    public class OpenGLRenderer : IRenderer
    {
        private I3DModel model;
        public I3DModel Model
        {
            set
            {
                model = value;
                model.SetActive();
            }
        }

        private ITexture texture;
        public ITexture Texture
        {
            set
            {
                texture = value;
                texture.SetActive();
            }
        }

        public void Render(bool advanced)
        {
            Console.WriteLine("OpenGL is rendering model...");
        }
    }
}
