using System.Runtime.Versioning;

namespace Tic_Tac_Toe.DepricatedCode.Menu
{
    public interface IMenu
    {
        string Title { get; }
        int SelectedIndex { get; }
        int Width { get; set; }
        int Height { get; set; }
        const int Padding = 2;
        List<Option> Options { get; }
        void Run();
        public void DisplayInititalize()
        {
            SetConsoleSize();
            Console.Write("+" + new string('-', Width) + "+\n");
            Console.Write("|" + new string(' ', Width) + "|\n");
            Console.Write("|" + new string(' ', (Width - Title.Length) / 2) + Title +
                new string(' ', Title.Length % 2 != 0 ? (Width - Title.Length) / 2 + 1 : (Width - Title.Length) / 2) + "|\n");
            Console.Write("|" + new string(' ', Width) + "|\n");
            Console.Write("+" + new string('-', Width) + "+\n");
            Console.Write("|" + new string(' ', Width) + "|\n");
            foreach (var option in Options)
            {
                Console.Write("|" + new string(' ', (Width - option.Name.Length) / 2));
                if (Options.IndexOf(option) == SelectedIndex)
                {
                    InvertColour();
                    Console.Write(option.Name);
                    ResetColour();
                }
                else
                {
                    Console.Write(option.Name);
                }
                Console.Write(new string(' ',
                    option.Name.Length % 2 != 0 ? (Width - option.Name.Length) / 2 + 1 : (Width - option.Name.Length) / 2) + "|\n");
            }
            Console.Write("|" + new string(' ', Width) + "|\n");
            Console.Write("+" + new string('-', Width) + "+\n");
        }
        void DisplayUpdate();
        void GetInput();
        void Invoke(Option option)
        {
            option.Action.Invoke();
        }
        void SetConsoleSize()
        {
            int widest = Title.Length;
            foreach (Option option in Options)
            {
                if (option.Name.Length > widest)
                {
                    widest = option.Name.Length;
                }
            }
            Width = Padding + widest + Padding;
            Height =
                Padding
                + 1
                + Padding
                + Options.Count * 2
                + Padding;
            //WindowsOnlyAPI(Width, Height);
        }

        [SupportedOSPlatform("windows")]
        void WindowsOnlyAPI(int Width, int Height)
        {
            Console.SetWindowSize(Width, Height);
        }

        void InvertColour()
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
        }

        void ResetColour()
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
        }

        public struct Option
        {
            public string Name { get; }
            public Action Action { get; }

            public Option(string name, Action action)
            {
                Name = name;
                Action = action;
            }
        }
    }
}