﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RP_PELICULAS.Modelos
{
    public class Pelicula
    {
      public int Id { get; set; }
      public string Titulo { get; set; }
      public string Genero { get; set; }
      public decimal Precio { get; set; }
       [DataType(DataType.Date)] //va mostrar solo la fecha en la página web creada
      public DateTime FechaLanzamiento { get; set; }
      public string Descripcion { get; set; }
    }
}
    