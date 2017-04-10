using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GraphicsAPI.Interfaces;
using GraphicsAPI.Implementations;

namespace GraphicsAPI
{
    public class DirectXFactory : AbstractFactory
    {
        public override I3DModel Create3DModel()
        {
            return new DirectX3DModel();
        }

        public override IRenderer CreateRenderer()
        {
            return new DirectXRenderer();
        }

        public override ITexture CreateTexture()
        {
            return new DirectXTexture();
        }
    }
}
