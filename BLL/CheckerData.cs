using System.Text.RegularExpressions;

namespace BLL
{
    public  class CheckerData
    {
        public string Patron { get; set; }
        public string Valor { get; set; }
        public bool Checker()
        {
            Regex obj = new Regex(Patron);
            MatchCollection resul = obj.Matches(Valor);
            if (resul.Count > 0)
                return true;
            else
                return false;
        }
    }
}
