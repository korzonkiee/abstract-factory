using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GraphicsAPI.Interfaces;
using GraphicsAPI.Implementations;

namespace GraphicsAPI
{
    public class OpenGLFactory : AbstractFactory
    {
        public override I3DModel Create3DModel()
        {
            return new OpenGL3DModel();
        }

        public override IRenderer CreateRenderer()
        {
            return new OpenGLRenderer();
        }

        public override ITexture CreateTexture()
        {
            return new OpenGLTexture();
        }
    }
}
