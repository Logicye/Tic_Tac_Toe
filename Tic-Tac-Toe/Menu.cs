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
        private string title;
        private List<Option>? options;
        private int selectedIndex;
        public Menu(string title, params KeyValuePair<string, Action>[] optionPairs) 
        {
            this.title = title;
            this.selectedIndex = 0;
            foreach (KeyValuePair<string, Action> pair in optionPairs)
            {
                this.options.Add(new Option(pair.Key, pair.Value));
            }
        }

        struct Option
        {
            private string name;
            private Action action;
            public Option(string name, Action action)
            {
                this.name = name;
                this.action = action;
            }

            public string Name() {  return name; }
            
            public void Invoke()
            {
                action.Invoke();
            }
        }

        private void DisplayMenu()
        {
            do
            {
                Console.WriteLine();
                foreach (Option option in options)
                {
                    Console.WriteLine(option.Name());
                }
            } while (true);
        }
    }
}
