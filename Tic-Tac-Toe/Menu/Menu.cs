using System.Drawing;
using System.Collections.Specialized;
using System.Diagnostics;
using Tic_Tac_Toe.Handlers;

namespace Tic_Tac_Toe.Menu
{
    class Menu : IConsoleEvents
    {
        #region Frame Variables
        private char corner = '+';
        private char horizontalLine = '-';
        private char verticalLine = '|';
        private char whiteSpace = ' ';
        private bool colorizeWhiteSpace = false;
        ConsoleColor frameBackgroundColor = ConsoleColor.Black;
        ConsoleColor frameTextColor = ConsoleColor.White;
        #endregion

        #region Menu Padding Variables
        private int titlePadding;
        private int widthPadding;
        private int optionPadding;
        private int optionSpacing;
        #endregion

        #region Menu  Variables
        private int maxLength;
        private int selectedOption = 0;
        private string title;

        private Dictionary<Option, Point> options;
        private List<string> frame;

        ConsoleColor menuBackgroundColor = ConsoleColor.Black;
        ConsoleColor menuTextColor = ConsoleColor.White;
        ConsoleColor selectedOptionBackgroundColor = ConsoleColor.White;
        ConsoleColor selectedOptionTextColor = ConsoleColor.Black;
        #endregion

        public Menu(string title, List<Option> options, int widthPadding = 3, int titlePadding = 1, int optionPadding = 1, int optionSpacing = 0)
        {
            Console.CursorVisible = false;
            this.title = title;
            this.widthPadding = widthPadding;
            this.titlePadding = titlePadding;
            this.optionPadding = optionPadding;
            this.optionSpacing = optionSpacing;

            this.options = new Dictionary<Option, Point>();
            frame = new List<string>();

            maxLength = title.Length;
            foreach (var option in options)
            {
                if (option.Name.Length > maxLength) { maxLength = option.Name.Length; }
            }

            int row = this.titlePadding * 2 + this.optionPadding + 3;
            foreach (Option option in options)
            {
                this.options.Add(option, new Point(FindHorizontalCursorPos(option.Name), row));
                row += optionSpacing + 1;
            }
            Console.Clear();
            InitializeFrame();
            Register();
        }

        #region Input Methods

        private void ScrollUp()
        {
            if (selectedOption > 0)
            {
                selectedOption--;
            }
            else
            {
                return;
            }
            DisplayOptions();
        }
        private void ScrollDown()
        {
            if (selectedOption < options.Count - 1)
            {
                selectedOption++;
            }
            else
            {
                return;
            }
            DisplayOptions();
        }
        private void SelectOption()
        {
            try
            {
                var option = options.ElementAt(selectedOption);
                option.Key.Invoke();
                Unregister();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }
        private void Escape()
        {
            Unregister();
            var option = options.ElementAt(options.Count - 1);
            option.Key.Invoke();
        }
        public void Register()
        {
            ConsoleKeyboardEventHandler.KeyPressed += OnKeyPressed;
        }
        public void Unregister()
        {
            ConsoleKeyboardEventHandler.KeyPressed -= OnKeyPressed;
        }
        public void OnKeyPressed(ConsoleKey key)
        {
            switch (key)
            {
                case ConsoleKey.UpArrow:
                    ScrollUp();
                    break;
                case ConsoleKey.W:
                    ScrollUp();
                    break;
                case ConsoleKey.DownArrow:
                    ScrollDown();
                    break;
                case ConsoleKey.S:
                    ScrollDown();
                    break;
                case ConsoleKey.Enter:
                    SelectOption();
                    break;
                case ConsoleKey.Spacebar:
                    SelectOption();
                    break;
                case ConsoleKey.Escape:
                    Escape();
                    break;
            }
        }
        #endregion

        #region Frame and Option Methods
        private void GenerateFrame()
        {
            //standard row formats
            string rowDivider = corner + new string(horizontalLine, maxLength + widthPadding * 2) + corner;
            string vertEnds = verticalLine + new string(whiteSpace, maxLength + widthPadding * 2) + verticalLine;

            //Title Section
            frame.Clear();
            frame.Add(rowDivider);
            for (int i = 0; i < titlePadding * 2 + 1; i++)
            {
                frame.Add(vertEnds);
            }
            frame.Add(rowDivider);

            //Option Section
            for (int i = 0; i < optionPadding * 2; i++)
            {
                frame.Add(vertEnds);
            }
            for (int i = 0; i < optionSpacing * options.Count - 1; i++)
            {
                frame.Add(vertEnds);
            }
            for (int i = 0; i < options.Count; i++)
            {
                frame.Add(vertEnds);
            }
            frame.Add(rowDivider);
        }
        public void InitializeFrame()
        {
            GenerateFrame();
            foreach (var line in frame)
            {
                Console.WriteLine();
            }
            UpdateFrame();
        }
        private void UpdateFrame()
        {
            UseFrameColor();
            Point currentCursorPos = new Point(0, 0);
            foreach (var line in frame)
            {
                foreach (var text in line)
                {
                    if (text != whiteSpace || colorizeWhiteSpace == true)
                    {
                        Console.SetCursorPosition(currentCursorPos.X, currentCursorPos.Y);
                        Console.Write(text);
                    }
                    currentCursorPos.X++;
                }
                currentCursorPos.X = 0;
                currentCursorPos.Y++;
            }
            Console.SetCursorPosition(FindHorizontalCursorPos(title), 1 + titlePadding);
            Console.Write(title);
            ColorReset();
            DisplayOptions();
        }
        public void AlterFrameAttributes(char corner = '+', char horizontalLine = '-', char verticalLine = '|', char whiteSpace = ' ', ConsoleColor textColor = ConsoleColor.White, ConsoleColor backgroundColor = ConsoleColor.Black, bool colorizeWhiteSpace = false)
        {
            this.corner = corner;
            this.horizontalLine = horizontalLine;
            this.verticalLine = verticalLine;
            this.whiteSpace = whiteSpace;
            frameTextColor = textColor;
            frameBackgroundColor = backgroundColor;
            this.colorizeWhiteSpace = colorizeWhiteSpace;
            GenerateFrame();
            UpdateFrame();
        }
        private void DisplayOptions()
        {
            int count = 0;
            foreach (var option in options)
            {
                if (selectedOption == count) { UseSelectedOptionColor(); }
                Console.SetCursorPosition(option.Value.X, option.Value.Y);
                Console.Write(option.Key.Name);
                count++;
                ColorReset();
            }
        }
        #endregion

        #region Color Control Methods
        private void ColorReset()
        {
            Console.ForegroundColor = menuTextColor;
            Console.BackgroundColor = menuBackgroundColor;
        }
        private void UseFrameColor()
        {
            Console.ForegroundColor = frameTextColor;
            Console.BackgroundColor = frameBackgroundColor;
        }
        private void UseSelectedOptionColor()
        {
            Console.ForegroundColor = selectedOptionTextColor;
            Console.BackgroundColor = selectedOptionBackgroundColor;
        }
        #endregion

        private int FindHorizontalCursorPos(string value)
        {
            return (maxLength + 2 + widthPadding * 2) / 2 - value.Length / 2;
        }

        ~Menu()
        {
            Debug.WriteLine($"The menu titled {title} has been disposed");
        }

        public struct Option
        {
            public string Name { get; }
            private readonly Action action;
            public Option(string name, Action Action)
            {
                Name = name;
                action = Action;
            }
            public void Invoke()
            {
                action.Invoke();
            }
        }

    }
}