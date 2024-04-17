using System.Diagnostics;
using Tic_Tac_Toe.Handlers;

namespace Tic_Tac_Toe.DepricatedCode.Menu
{
    internal class oldMenu
    {
        private readonly string _title;
        private readonly List<Option> _options;
        private int _selectedIndex;
        public oldMenu(string title, params KeyValuePair<string, Action>[] optionPairs)
        {
            _title = title;
            _selectedIndex = 0;
            _options = new();
            foreach (KeyValuePair<string, Action> pair in optionPairs)
            {
                _options.Add(new Option(pair.Key, pair.Value));
            }
        }

        readonly struct Option
        {
            private readonly string name;
            private readonly Action action;
            public Option(string name, Action action)
            {
                this.name = name;
                this.action = action;
            }

            public readonly string Name() { return name; }

            public void Invoke()
            {
                action.Invoke();
            }
        }

        private void Display()
        {
            Console.CursorVisible = false;
            Console.Clear();
            Console.WriteLine(_title);
            foreach (Option option in _options)
            {
                if (option.Name() == _options[_selectedIndex].Name())
                {
                    Console.WriteLine(" > " + option.Name());
                }
                else
                {
                    Console.WriteLine("   " + option.Name());
                }
            }
            //MenuInputHandle();
        }

        private void DisplayUpdate()
        {
            for (int i = 0; i < _options.Count; i++)
            {
                Console.SetCursorPosition(1, i + 1);
                if (i == _selectedIndex)
                {
                    Console.Write(">");
                }
                else
                {
                    Console.Write(" ");
                }
            }
            /*
            int count = 0;
            foreach (Option option in options)
            {
                Console.SetCursorPosition(1, count + 1);
                if (count == _selectedIndex)
                {
                    Console.Write(">");
                }
                else
                {
                    Console.Write(" ");
                }
                count++;
            }
            */
        }

        private void MenuInputHandle()
        {
            ConsoleKeyInfo keyInfo;
            do
            {
                keyInfo = Console.ReadKey(true);
                if (keyInfo.Key == ConsoleKey.UpArrow)
                {
                    if (_selectedIndex == 0)
                    {
                        _selectedIndex = _options.Count - 1;
                    }
                    else
                    {
                        _selectedIndex--;
                    }
                }
                else if (keyInfo.Key == ConsoleKey.DownArrow)
                {
                    if (_selectedIndex == _options.Count - 1)
                    {
                        _selectedIndex = 0;
                    }
                    else
                    {
                        _selectedIndex++;
                    }
                }
                else if (keyInfo.Key == ConsoleKey.Enter)
                {
                    _options[_selectedIndex].Invoke();
                    break;
                }
                DisplayUpdate();
            } while (true);
        }
    }
}
