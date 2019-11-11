using System;
using System.Collections.Generic;
using System.Text;

namespace Fuels.Models
{
    public class FuelsModel
    {

            public string Combustible { get; set; }
            public string Precio { get; set; }
            public string Variante { get; set; }
            public string Icono { get; set; }
           public bool Visible
        {
            get
            {
                if (Icono == "pause")
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        public bool VisibleDown
        {
            get
            {
                if (Icono == "trending_down")
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public bool VisibleUp
        {
            get
            {
                if (Icono == "trending_up")
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        public string Color { get; set; }
        }


    }

