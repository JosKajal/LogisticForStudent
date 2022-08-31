using System;
using System.Collections.Generic;
using System.Text;

namespace LogisticForStudent
{
    public class Guiasinf
    {
        public ObservableColletion<string> Itemlist { get; set; }

        public Guiasinf()
        {
            // Itemlist = new string[] { "Credenciales", "Constancias Estudios", "Certificados", "Horarios", "Ciclo escolar" };
            Itemlist = new ObservableColletion<string>();
            Itemlist.Add("Credenciales", "Constancias Estudios", "Certificados", "Horarios", "Ciclo escolar");
            Itemlist.Add("Credenciales");
            Itemlist.Add("Constancias de estudios");
            Itemlist.Add("Horarios");


        }
    }

}
