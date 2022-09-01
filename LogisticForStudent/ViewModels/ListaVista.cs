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
            Guias.Add(new VistaModelo { Name = "Credenciales", Imagen = "https://cdn-icons-png.flaticon.com/512/1022/1022464.png", Detail = "Servicios Escolares", Horarios = "L-V 8:00-14:00\r  16:00-19:00" });
            Guias.Add(new VistaModelo { Name = "Servicio Social", Imagen = "https://cdn-icons-png.flaticon.com/512/3233/3233092.png", Detail = "Edificio AA Vinculacion", Horarios = "L-V 8:00-14:00" });
            Guias.Add(new VistaModelo { Name = "Finanzas", Imagen = "https://cdn-icons-png.flaticon.com/512/3233/3233092.png", Detail = "Servicios escolares", Horarios = "L-V 8:00-14:00" });
            Guias.Add(new VistaModelo { Name = "Residencias", Imagen = "https://cdn-icons-png.flaticon.com/512/3233/3233092.png", Detail = "Edificio AA Vinculacion", Horarios = "L-V 8:00-14:00" });
            Guias.Add(new VistaModelo { Name = "Constancia Estudios", Imagen = "https://cdn-icons-png.flaticon.com/512/3233/3233092.png", Detail = "Servicios escolares", Horarios = "L-V 8:00-14:00" });
            Guias.Add(new VistaModelo { Name = "Horarios", Imagen = "https://cdn-icons-png.flaticon.com/512/3290/3290206.png", Detail = "Division de Estudios", Horarios = "L-V 8:00-14:00" });

        }
    }
}
