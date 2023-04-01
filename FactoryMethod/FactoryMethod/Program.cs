using FactoryMethod.Abstracts;
using FactoryMethod.Concretes;

namespace FactoryMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dialog dialog = new WindowsDialog();
            var button = dialog.CreateButton();
            button.OnClick();
            button.Render();


            Dialog dialog2 = new WebDialog();
            var button2 = dialog2.CreateButton();
            button2.OnClick();
            button2.Render();

        }
    }
}