using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1
{
    public class Triangle : Forme
    {
		private int a;

		public int A
		{
			get { return a; }
			set { a = value; }
		}

		private int b;

		public int B
		{
			get { return b; }
			set { b = value; }
		}

		private int c;

		public int C
		{
			get { return c; }
			set { c = value; }
		}

		public override double Aire => throw new NotImplementedException();

		public override double Perimetre => throw new NotImplementedException();
	}
}
