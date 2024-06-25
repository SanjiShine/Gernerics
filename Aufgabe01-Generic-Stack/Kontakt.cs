using System;
namespace Aufgabe01_Generic_Stack
{
	public class Kontakt : IComparable<Kontakt> // Klasse Kontakt erstellen - Icomparable<T>-Interface implementiert
    {
		public string Name { get; set; }
		public int Telefonnummer { get; set; }

		public Kontakt(string name, int telefonummer)
		{
			this.Name = name;
			this.Telefonnummer = telefonummer;
		}

		public int CompareTo(Kontakt kontakt)
		{
			if (kontakt == null) throw new Exception("Kontakt ist leer!");
			return Name.CompareTo(kontakt.Name);
		}

        public override string ToString()
        {
            return $"{Name} - {Telefonnummer}";
        }
    }
}

