using GH.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GH.DAL.Interfaces
{
    public interface IBarkodDAL
    {
        bool BarkodVarMi(Guid Barkod);

        BarkodResultDTO BarkodArama(Guid Barkod);
    }
}
