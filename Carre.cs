using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1
{
    public class Carre : Forme
    {
		private int longueur;

		public int Longueur
		{
			get { return longueur; }
			set { longueur = value; }
		}

		public override double Aire => Longueur*Longueur;

		public override double Perimetre => Longueur * 4;
	}
}
