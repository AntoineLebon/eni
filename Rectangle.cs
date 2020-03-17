using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1
{
    public class Rectangle : Forme
    {
		private int longueur;

		public int Longueur
		{
			get { return longueur; }
			set { longueur = value; }
		}

		private int largeur;

		public int Largeur
		{
			get { return largeur; }
			set { largeur = value; }
		}

		public override double Aire => Largeur * Longueur;

		public override double Perimetre => (Longueur * 2) + (Largeur * 2);
	}
}
