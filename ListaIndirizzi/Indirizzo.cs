using System;
using System.Runtime.CompilerServices;

namespace ListaIndirizzi
{
	public class Indirizzo
	{
		private string name;
		private string surname;
		private string street;
		private string city;
		private string province;
		private string zip;

		public Indirizzo (string name, string surname, string street, string city, string province, string zip) {
			this.name = name;
			this.surname = surname;
			this.street = street;
			this.city = city;
			this.province = province;
			this.zip = zip;
		}
	}
}

