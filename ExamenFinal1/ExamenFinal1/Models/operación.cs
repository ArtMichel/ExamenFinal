using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ExamenFinal1.Models
{
    public class operación
    {
        [Key]
        public int numero { get; set; }
        public string Operacion
        {
            get
            {
                if (numero < 0)
                {
                    return "ERROR";
                }
                else if (numero == 0)
                {
                    return "Arturo Michel";
                }
                else 
                { 
                    return $"{numero}"; 
                }
            }
        }
    }
}