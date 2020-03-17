using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1
{
    public class Cercle : Forme	
    {
		private int rayon;

		public int Rayon
		{
			get { return rayon; }
			set { rayon = value; }
		}

		public override double Aire => Math.PI * Rayon * Rayon;

		public override double Perimetre
		{
			get { return 2 * Math.PI * Rayon; }
		}
	}
}
