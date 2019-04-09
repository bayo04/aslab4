using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aslab4
{
    class Operacija
    {
        public void dodaj(string novaBoja, List<Boja> listaBoja)
        {
            Boja nova = new Boja(novaBoja);
            listaBoja.Add(nova);
        }
        public string promjeni(int brojac, List<Boja> listaBoja)
        {
            string boja="";
            boja = listaBoja[brojac % listaBoja.Count].Hex;
            return boja;
        }
    }
}
