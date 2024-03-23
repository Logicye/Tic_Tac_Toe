using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic_Tac_Toe
{
    internal class Menu
    {
        private readonly string title;
        private readonly List<Option> options = new ();
        private int selectedIndex;
        public Menu(string title, params KeyValuePair<string, Action>[] optionPairs) 
        {
            this.title = title;
            this.selectedIndex = 0;
            foreach (KeyValuePair<string, Action> pair in optionPairs)
            {
                this.options.Add(new Option(pair.Key, pair.Value));
            }
            DisplayMenu();
        }

        struct Option
        {
            private readonly string name;
            private readonly Action action;
            public Option(string name, Action action)
            {
                this.name = name;
                this.action = action;
            }

            public readonly string Name() {  return name; }
            
            public void Invoke()
            {
                action.Invoke();
            }
        }

        private void DisplayMenu()
        {
            ConsoleKeyInfo keyInfo;
            do
            {
                Console.WriteLine(title);
                foreach (Option option in options)
                {
                    Console.WriteLine(option.Name());
                }
                keyInfo = Console.ReadKey();
                if (ConsoleKey.D1 == keyInfo.Key)
                {
                    options[0].Invoke();
                }
                if (ConsoleKey.D2 == keyInfo.Key)
                {
                    options[1].Invoke();
                }
                if (ConsoleKey.D3 == keyInfo.Key)
                {
                    options[2].Invoke();
                }
                Console.WriteLine();
            } while (true);
        }
    }
}
