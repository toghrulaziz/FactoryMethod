using FactoryMethod.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Concretes
{
    internal class WindowsButton : IButton
    {
        public void OnClick() => Console.WriteLine("Windows Button Clicked");

        public void Render() => Console.WriteLine("Windows Button");
    }
}
