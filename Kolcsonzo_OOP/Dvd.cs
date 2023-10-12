using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolcsonzo_OOP
{
	internal class Dvd : IKolcsonozheto, IComparable<Dvd>
	{
		private string cim;
		private int hossz;

		public Dvd(string cim, int hossz)
		{
			this.cim = cim;
			this.hossz = hossz;
		}

		public string MegjelenitendoNev { get => $"{this.cim} ({this.hossz})"; set => throw new NotImplementedException(); }
		public int MeddigKolcsonozheto { get => 7; set => throw new NotImplementedException(); }

		public int CompareTo(Dvd other)
		{
			return this.hossz - other.hossz;
		}
	}
}
