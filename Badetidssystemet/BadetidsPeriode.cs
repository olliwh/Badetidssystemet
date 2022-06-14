using System;
using System.Collections.Generic;
using System.Text;

namespace Badetidssystemet
{
    public class BadetidsPeriode
    {
        private string _type = "Badning";
        private DayOfWeek _ugeDag = DayOfWeek.Sunday;
        private DateTime _startTidspunkt;
        private DateTime _slutTidspunkt;
        private Dictionary<string, Kreds> _kredse;

        public BadetidsPeriode(string type, DayOfWeek ugeDag, DateTime startTidspunkt, DateTime slutTidspunkt)
        {
            try
            {
                if (type.Length < 4)
                {
                    throw new ArgumentException();
                }

            }
            catch (ArgumentException)
            {
                Console.WriteLine("Type skal være længere");
            }

            try
            {
                if (startTidspunkt >= slutTidspunkt)
                {
                    throw new ArgumentException();
                }

            }
            catch (ArgumentException)
            {
                Console.WriteLine($"Start tidspunkt er den samme eller senere end slut tidspunkt");
            }
            _type = type;
            _ugeDag = ugeDag;
            _startTidspunkt = startTidspunkt;
            _slutTidspunkt = slutTidspunkt;
            _kredse = new Dictionary<string, Kreds>();
        }

        public string Type { get { return _type; } 
            set 
            {
                try
                {
                    if (value.Length < 4)
                    {
                        throw new ArgumentException();
                    }
                    else
                    {
                        _type = value;
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Type skal være længere");
                }
                
            } 
        }
        public DayOfWeek UgeDag { get { return _ugeDag; } set { _ugeDag = value; } }

        public DateTime StartTidspunkt 
        { get { return _startTidspunkt; } 
            set 
            {
                try
                {
                    if (value >= _slutTidspunkt)
                    {
                        throw new ArgumentException();
                    }
                    else
                    {
                        _startTidspunkt = value;
                    }
                }
                catch (ArgumentException)
                {
                    Console.WriteLine($"Start tidspunkt er den samme eller senere end slut tidspunkt");
                }
            } 
        }

        public DateTime SlutTidspunkt { get { return _slutTidspunkt; } 
            set 
            {
                try
                {
                    if (value <= _startTidspunkt)
                    {
                        throw new ArgumentException();
                    }
                    else
                    {
                        _slutTidspunkt = value;
                    }
                }
                catch (ArgumentException)
                {
                    Console.WriteLine($"Start tidspunkt er den samme eller senere end slut tidspunkt");
                }
                _slutTidspunkt = value; 
            } 
        }

        public Dictionary<string, Kreds> Kredse { get { return _kredse; } 
            set 
            { 
                _kredse = value; 
            } 
        }

        public virtual void AdderKreds(Kreds kreds)
        {
            bool erIDTilmeldt = false;

            foreach(Kreds k in _kredse.Values)
            {
                if(k.ID == kreds.ID)
                {
                    erIDTilmeldt = true;
                }
            }
            if(_kredse.Count >= 10)
            {
                Console.WriteLine("Søen er fyldt der er ikke plads til flere Kredse");
            }
            else if (erIDTilmeldt == false)
            {
                _kredse.Add(kreds.ID, kreds);
                Console.WriteLine($"{kreds.Navn} blev tilføjet");
            }
            else
            {
                Console.WriteLine($"{kreds.ID}er allerede tilføjet");
            }

        }
        public virtual void SletKreds(string id)
        {
            _kredse.Remove(id);
        }
        public override string ToString()
        {
            string kredseStr = string.Empty;
            while (_kredse.Count > 0)
            {
                kredseStr = "Kredse:\n";
                foreach (Kreds k in _kredse.Values)
                {
                    kredseStr += k;
                }
                break;
            }
            return $"Type: {_type}, Ugedag: {_ugeDag}, Start tidspunkt: {_startTidspunkt}, Slut tidspunkt: {_slutTidspunkt}\n{kredseStr}";
        }

    }
}
