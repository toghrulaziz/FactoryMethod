using FactoryMethod.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Concretes
{
    internal class WindowsDialog : Dialog
    {
        public override IButton CreateButton() => new WindowsButton();
    }
}
