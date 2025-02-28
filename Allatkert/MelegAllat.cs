using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Allatkert
{
	internal class MelegAllat
	{
		int sebesseg;
		string faj;
		string nev;
		int suly;
		string nem;

		public MelegAllat(int sebesseg, string faj, string nev, int suly, string nem)
		{
			this.sebesseg = sebesseg;
			this.faj = faj;
			this.nev = nev;
			this.suly = suly;
			this.nem = nem;
		}

		public int Sebesseg { get => sebesseg; set => sebesseg = value; }
		public string Faj { get => faj; set => faj = value; }
		public string Nev { get => nev; set => nev = value; }
		public int Suly { get => suly; set => suly = value; }
		public string Nem { get => nem; set => nem = value; }
	}
}
