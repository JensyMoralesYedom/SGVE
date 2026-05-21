using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CDResultado
    {

        #region Variables
        private bool dExito = false;
        private int dIdResult = 0;
        private string dMsg = string.Empty;

        public bool Exito
        {
            get { return dExito; }
            set { dExito = value; }
        }

        public int IdResult
        {
            get { return dIdResult; }
            set { dIdResult = value; }
        }

        public string Msg
        {
            get { return dMsg; }
            set { dMsg = value; }
        }

        #endregion


        public CDResultado() { }

        public CDResultado(string msg, int IdResult, bool exito)
        {
            this.dMsg = msg;
            this.dIdResult = IdResult;
            this.dExito = exito;
        }

    }
}
