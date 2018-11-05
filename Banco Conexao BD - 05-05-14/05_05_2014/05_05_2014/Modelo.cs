using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _05_05_2014
{
    class Modelo
    {
        private int vcodigo;
        private string vnome;
        private string vemail;

        public int codigo
        {
            get { return vcodigo; }
            set { vcodigo = value; }
        }

        public string nome
        {
            get { return vnome; }
            set { vnome = value; }
        }

        public string email
        {
            get { return vemail; }
            set { vemail = value; }
        }


        }
    }

