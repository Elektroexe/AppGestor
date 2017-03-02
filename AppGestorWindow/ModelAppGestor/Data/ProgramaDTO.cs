using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelAppGestor.Data
{
    public partial class ProgramaDTO
    {
        public int CODIGO { get; set; }
        public Nullable<int> CODIGOCAT { get; set; }
        public string NOMBRE { get; set; }
        public string PLATAFORMA { get; set; }
        public string VERSION { get; set; }
        public Nullable<int> DESCARGAS { get; set; }
        public string HOST { get; set; }
        public Nullable<bool> INSTALADO { get; set; }
    }
}
