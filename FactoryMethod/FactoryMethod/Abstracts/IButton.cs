﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Abstracts
{
    internal interface IButton
    {
        void Render();
        void OnClick();
    }
}
