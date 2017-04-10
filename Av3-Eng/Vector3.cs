using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicsAPI
{
	public class Vector3
	{
		public double X;
		public double Y;
		public double Z;

		public Vector3 (double val)
		{
			X = Y = Z = val;
		}

		public Vector3 (double x, double y, double z)
		{
			X = x;
			Y = y;
			Z = z;
		}

		public override string ToString()
		{
			return $"{X}, {Y}, {Z}";
		}
	}
}
