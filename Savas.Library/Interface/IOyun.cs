﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Savas.Library.Enum;

namespace Savas.Library.Interface
{
    internal interface IOyun
    {
        bool DevamEdiyorMu { get;}
        TimeSpan GecenSure { get; }
        void Baslat();
        void AtesEt();
        void UcakSavariHareketEttir(Yon yon);
    }
}
