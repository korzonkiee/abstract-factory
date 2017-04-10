using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicsAPI.Interfaces
{
	public interface IRenderer
	{
		I3DModel Model { set; }
		ITexture Texture { set; }
		void Render(bool advanced);
	}
}
