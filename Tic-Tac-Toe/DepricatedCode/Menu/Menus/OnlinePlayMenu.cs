using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tic_Tac_Toe.DepricatedCode.Menu;

namespace Tic_Tac_Toe.DepricatedCode.Menu.Menus
{
    internal class OnlinePlayMenu : IMenu
    {
        public string Title { get; set; }
        public int SelectedIndex { get; set; }
        public List<IMenu.Option> Options { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }

        public OnlinePlayMenu()
        {
            Title = "Online Game";
            SelectedIndex = 0;
            Options = new List<IMenu.Option>
            {
                new IMenu.Option("Host New Game", () => new SinglePlayerMenu()),
                new IMenu.Option("Connect To Host", () => new MultiPlayerMenu()),
                new IMenu.Option("Return", () => new MultiPlayerMenu())
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
