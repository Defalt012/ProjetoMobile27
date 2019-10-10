using System;
using System.Collections.Generic;
using System.Text;

namespace AppMobile27.Classe
{
    public class ModelPedido
    {
        public int ID { get; set; }

        public int Quarto { get; set; }

        public int Banheiro { get; set; }

        public int Cozinha { get; set; }

        public int Sala { get; set; }

        public string Data { get; set; }

        public string Hora { get; set; }

        public string Empregado { get; set; }

        public int Total { get; set; }
    }
}
