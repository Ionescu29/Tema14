using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab14Tema14
{
    internal class Administration
    {
        //Sistemul de gestiune va fi unic la nivel de aplicatie si va fi modelat de o clasa care va avea urmatoarele :
        //Adauga un angajat dat ca parametru
        AddEmployee (Guid Id)
        {
            Id=0;
            return Id++;
        }
        //Sterge un angajat in functie de ID-ul acestuia
        RemoveEmployee(Guid Id)
        {
            return Id--;
        }
        //Metoda va primi ca parametru o valoare numerica si va returna o lista cu toti angajatii
        //cu salariul mai mare decat valoarea numerica oferita ca parametru
        


    }
}
