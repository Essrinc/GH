﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GH.Common
{
    public class Enums
    {
        public enum Rols
        {
            Normal = 1,
            Premium = 2,
            Admin = 3
        }

        public enum OnayDurum
        {
            Beklemede = 1,
            Reddedildi = 2,
            Kabul_Edildi = 3
        }

        public enum RiskSeviye
        {
            Temiz = 1,
            Az_Riskli = 2,
            Orta_Riskli = 3,
            Riskli = 4,
        }
    }
}
