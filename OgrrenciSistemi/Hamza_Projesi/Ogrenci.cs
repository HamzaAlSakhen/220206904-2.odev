using System;

namespace Ogrenciler
{


    public class Ogrenci
    {
        private string isim;
        private string dogumTarihi;
        private string bolum;
        private string telefonNo;
        private double vizeNotu;
        private double finalNotu;

        public Ogrenci()
        {

        }

        public int ID
        {
            get;
            set;
        }
        public string ISIM
        {
            get
            {
                return isim;
            }
            set
            {
                isim = value.ToUpper();
            }
        }
        public string DogumTarihi
        {
            get
            {
                return dogumTarihi;
            }
            set
            {
                dogumTarihi = value.Substring(0, 2);
                dogumTarihi += "." + value.Substring(3, 2);
                dogumTarihi += "." + value.Substring(6, 4);
            }
        }
        public string BOLUM
        {
            get
            {
                return bolum;
            }
            set
            {
                bolum = value.ToUpper();
            }
        }
        public string TELEFON
        {
            get
            {
                return telefonNo;
            }
            set
            {
                telefonNo = value;
            }
        }
        public double vize
        {
            get
            {
                return vizeNotu;
            }
            set
            {
                vizeNotu = value;
            }
        }
        public double final
        {
            get
            {
                return finalNotu;
            }
            set
            {
                finalNotu = value;
            }
        }
        public void yazdir()
        {
            Console.WriteLine("ID: {0}", ID);
            Console.WriteLine("Name: {0}", ISIM);
            Console.WriteLine("Dogum: {0}", DogumTarihi);
            Console.WriteLine("Telefon: {0}", TELEFON);
            Console.WriteLine("Bolum: {0}", BOLUM);
        }
    }

    //class Program
    //{
    //    public static void Main()
    //    {
    //        Ogrenci or1 = new Ogrenci();

    //        Console.Write("Enter the ID: ");
    //        or1.ID = int.Parse(Console.ReadLine());

    //        Console.Write("Enter the NAME: ");
    //        or1.ISIM = Console.ReadLine();

    //        Console.Write("Enter the BIRTHDAY: ");
    //        or1.DogumTarihi = Console.ReadLine();

    //        Console.Write("Enter the TELEFON: ");
    //        or1.TELEFON = Console.ReadLine();

    //        Console.Write("Enter the DEPARTMENT: ");
    //        or1.BOLUM = Console.ReadLine();

    //        or1.yazdir();
    //    }
    //}
}