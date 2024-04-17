using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tic_Tac_Toe.DepricatedCode.Menu;

namespace Tic_Tac_Toe.DepricatedCode.Menu.Menus
{
    internal class MultiPlayerMenu : IMenu
    {
        public string Title { get; set; }
        public int SelectedIndex { get; set; }
        public List<IMenu.Option> Options { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }

        public MultiPlayerMenu()
        {
            Title = "MultiPlayer";
            SelectedIndex = 0;
            Options = new List<IMenu.Option>
            {
                new IMenu.Option("Local Play", () => throw new NotImplementedException()),
                new IMenu.Option("Online Play", () => new OnlinePlayMenu()),
                new IMenu.Option("Return", () => new MainMenu())
            };
        }

        public void Run()
        {

        }

        public void DisplayInititalize()
        {
            //Console.WriteLine(new string('*', ));
        }

        public void DisplayUpdate()
        {

        }

        public void GetInput()
        {

        }

        public void Invoke(IMenu.Option option)
        {
            option.Action.Invoke();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
