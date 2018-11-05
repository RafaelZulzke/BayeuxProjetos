using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace revisao
{
        class cproduto
        {
            private string vproduto;
            private string vmarca;
            private float vvalor;
            private int vestoque;

            public string produto
            {
                get { return vproduto; }
                set { vproduto = value; }
            }
            public string marca
            {
                get { return vmarca; }
                set { vmarca = value; }
            }
            public float valor
            {
            get{return vvalor;}
                set {vvalor=value ;}
        }
            public int estoque
            {
                get { return vestoque;}
                set {vestoque=value ;}
            }

    }
}
