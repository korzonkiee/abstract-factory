using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicsAPI.Interfaces
{
	public interface I3DModel
	{
		Vector3 Position { set; }
		void SetActive();
	}
}
