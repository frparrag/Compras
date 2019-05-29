﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.TIENDAS
{
    public class TiendaDTO
    {
        public int Id { get; set; }

        [Required]
        public string Nombre { get; set; }
    }
}
