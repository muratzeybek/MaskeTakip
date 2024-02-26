using Business.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net;

namespace Workaround
{
    class Program
    {
        static void Main(string[] args)
        {

            // Degiskenler();

            Vatandas vatandas = new Vatandas();
            Console.WriteLine(vatandas.Ad);

            Console.ReadLine();

            PttManager pttManager = new PttManager(new CitizenManager());
            pttManager.GiveMask(new Citizen() { FirstName="Murat", LastName="ZEYBEK", DateOfBirthYear=1982, NationalIdentity=159} );
        }

        public static void Degiskenler()
        {
            string mesaj = "Merhaba";
            double tutar = 100000;
            int sayi = 100;
            bool girisYapmisMi = false;

            string ad = "Engin";
            string soyad = "Demiroğ";
            int dogumYili = 1985;
            long tcNo = 12345678910;
        }

        

    }

    
    public class Vatandas
    {
        /*
        public string ad = "Engin";
        public string soyad = "Demiroğ";
        public int dogumYili = 1985;
        public long tcNo = 12345678910;
        */

        public string Ad { get; set; }
        public string Soyad { get; set; }
        public int DogumYili { get; set; }
        public long TcNo { get; set; }
    }

}
