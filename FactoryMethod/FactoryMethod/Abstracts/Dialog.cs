using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace FactoryMethod.Abstracts
{
    internal abstract class Dialog
    {
        public virtual void Render() => Console.WriteLine("Dialog");

        public abstract IButton CreateButton();
    }
}
