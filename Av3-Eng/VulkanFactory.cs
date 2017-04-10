using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GraphicsAPI.Interfaces;
using GraphicsAPI.Implementations;

namespace GraphicsAPI
{
    public class VulkanFactory : AbstractFactory
    {
        public override I3DModel Create3DModel()
        {
            return new Vulkan3DModel();
        }

        public override IRenderer CreateRenderer()
        {
            return new VulkanRenderer();
        }

        public override ITexture CreateTexture()
        {
            return new VulkanTexture();
        }
    }
}
