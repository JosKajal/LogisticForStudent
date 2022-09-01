using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;
using LogisticForStudent.Models;

namespace LogisticForStudent.ViewModels
{
    public class ListaVista
    {
        public ObservableCollection<VistaModelo> Guias { get; set; }
        public ListaVista()
        {
            Guias = new ObservableCollection<VistaModelo>();
            Guias.Add(new VistaModelo { Name = "Credenciales", Imagen = "Ima1.png", Detail = "Servicios Escolares", Horarios = "L-V 8:00-14:00\r  16:00-19:00" });
            Guias.Add(new VistaModelo { Name = "Servicio Social", Imagen = "Ima3.png", Detail = "Edificio AA Vinculacion", Horarios = "L-V 8:00-14:00" });
            Guias.Add(new VistaModelo { Name = "Finanzas", Imagen = "Ima3.png", Detail = "Servicios escolares", Horarios = "L-V 8:00-14:00" });
            Guias.Add(new VistaModelo { Name = "Residencias", Imagen = "Ima3.png", Detail = "Edificio AA Vinculacion", Horarios = "L-V 8:00-14:00" });
            Guias.Add(new VistaModelo { Name = "Constancia Estudios", Imagen = "Ima3.png", Detail = "Servicios escolares", Horarios = "L-V 8:00-14:00" });
            Guias.Add(new VistaModelo { Name = "Horarios", Imagen = "Ima2.png", Detail = "Division de Estudios", Horarios = "L-V 8:00-14:00" });

        }
    }
}
