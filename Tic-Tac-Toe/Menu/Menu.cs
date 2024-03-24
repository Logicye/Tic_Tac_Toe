namespace Tic_Tac_Toe.Menu
{
    internal class Menu
    {
        private readonly string title;
        private readonly List<Option> options = new();
        private int selectedIndex;
        public Menu(string title, params KeyValuePair<string, Action>[] optionPairs)
        {
            this.title = title;
            selectedIndex = 0;
            foreach (KeyValuePair<string, Action> pair in optionPairs)
            {
                options.Add(new Option(pair.Key, pair.Value));
            }
            Display();
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
            Console.WriteLine(title);
            foreach (Option option in options)
            {
                if (option.Name() == options[selectedIndex].Name())
                {
                    Console.WriteLine(" > " + option.Name());
                }
                else
                {
                    Console.WriteLine("   " + option.Name());
                }
            }
            MenuInputHandle();
        }

        private void DisplayUpdate()
        {
            int count = 0;
            foreach (Option option in options)
            {
                Console.SetCursorPosition(1, count + 1);
                if (count == selectedIndex)
                {
                    Console.Write(">");
                }
                else
                {
                    Console.Write(" ");
                }
                count++;
            }
        }

        private void MenuInputHandle()
        {
            ConsoleKeyInfo keyInfo;
            do
            {
                keyInfo = Console.ReadKey();
                if (keyInfo.Key == ConsoleKey.UpArrow)
                {
                    if (selectedIndex == 0)
                    {
                        selectedIndex = options.Count - 1;
                    }
                    else
                    {
                        selectedIndex--;
                    }
                }
                else if (keyInfo.Key == ConsoleKey.DownArrow)
                {
                    if (selectedIndex == options.Count - 1)
                    {
                        selectedIndex = 0;
                    }
                    else
                    {
                        selectedIndex++;
                    }
                }
                else if (keyInfo.Key == ConsoleKey.Enter)
                {
                    options[selectedIndex].Invoke();
                    break;
                }
                DisplayUpdate();
            } while (true);
        }
    }
}
