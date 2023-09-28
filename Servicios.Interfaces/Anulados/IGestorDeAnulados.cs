using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Interfaces.Anulados
{
    public interface IGestorDeAnulados
    {
        void cur_tmp_datosprod_histo(string codempresa, string ventadethist, int histo, int correl);
    }
}
