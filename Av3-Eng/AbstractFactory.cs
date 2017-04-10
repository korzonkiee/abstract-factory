using GraphicsAPI.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicsAPI
{
    public abstract class AbstractFactory
    {
        public abstract I3DModel Create3DModel();
        public abstract IRenderer CreateRenderer();
        public abstract ITexture CreateTexture();
    }
}
