using System;
using System.Collections.Generic;
using System.Text;

namespace Badetidssystemet
{
    public class Kreds
    {
        private string _id;
        private string _navn;
        private string _adresse;
        private int _antalDeltagere;

        public Kreds(string id, string navn, string adresse, int antalDeltagere)
        {
            _id = id;
            _navn = navn;
            _adresse = adresse;
            _antalDeltagere = antalDeltagere;

            try
            {
                if (_antalDeltagere < 1)
                {
                    throw new ArgumentException();
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Antal deltagere skal være over 0");
            }
        }

        public string ID { get { return _id; } set { _id = value; } }
        public string Navn { get { return _navn; } set { _navn = value; } }
        public string Adresse { get { return _adresse; } set { _adresse = value; } }

        public int AntalDeltagere { get { return _antalDeltagere; } 
            set 
            {
                // OPGAVE 6
                //if (_antalDeltagere < 1)
                //{
                //    _antalDeltagere = value;
                //}
                //else
                //{
                //    Console.WriteLine("Antal deltagere skal være over 0");
                //}
                try
                {
                    if (value < 1)
                    {
                        throw new ArgumentException();
                    }
                    else
                    {
                        _antalDeltagere = value;
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Antal deltagere skal være over 0");
                }
            } 
        }
        public void EditKreds(string id, string navn, string adresse, int antalDeltagere)
        {
            _id = id;
            _navn = navn;
            _adresse = adresse;
            _antalDeltagere = antalDeltagere;
        }
        public override string ToString()
        {
            return $"ID: {_id}, Navn: {_navn}, Adresse: {_adresse}, Antal Deltagere: {_antalDeltagere}\n";
        }
    }
}
