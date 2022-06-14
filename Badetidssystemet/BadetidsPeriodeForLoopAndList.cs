using System;
using System.Collections.Generic;
using System.Text;

namespace Badetidssystemet
{
    public class BadetidsPeriodeForLoopAndList : BadetidsPeriode
    {
        private List<Kreds> _kredsList;
        public BadetidsPeriodeForLoopAndList(string type, DayOfWeek ugeDag, DateTime startTidspunkt, DateTime slutTidspunkt)
            : base(type, ugeDag, startTidspunkt, slutTidspunkt)
        {
            _kredsList = new List<Kreds>();
        }
        public override void AdderKreds(Kreds kreds)
        {
            _kredsList.Add(kreds);
        }
        public override void SletKreds(string id)
        {
            foreach (Kreds k in _kredsList)
            {
                if (k.ID == id)
                {
                    _kredsList.Remove(k);
                    break;
                }
            }
        }
        public override string ToString()
        {
            string listItems = string.Empty;
            while (_kredsList.Count > 0)
            {
                listItems += _kredsList;
                for (var i = 0; i < _kredsList.Count; i++)
                {
                    listItems += _kredsList[i] + "\n";
                }
                break;
            }
            return $"{base.ToString()} {listItems}";
        }

    }
}
