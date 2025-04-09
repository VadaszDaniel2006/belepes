using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace belepes
{
   
    public class tanulo
    {
        int id;
        string nev;
        int atlag;

        public tanulo(int id, string nev, int atlag)
        {
            this.Id = id;
            this.Nev = nev;
            this.Atlag = atlag;
        }

        public int Id { get => id; set => id = value; }
        public string Nev { get => nev; set => nev = value; }
        public int Atlag { get => atlag; set => atlag = value; }
    
        List<tanulo> adatlista = new List<tanulo>();
    }
   
}
