using FactoryMethod.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace FactoryMethod.Concretes
{
    internal class HTMLButton : IButton
    {
        public void OnClick() => Console.WriteLine("HTML Button Clicked");

        public void Render() => Console.WriteLine("HTML Button");
    }
}
