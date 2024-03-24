using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic_Tac_Toe.Handlers
{
    internal class InputEventHandler
    {
        public delegate void KeyPressed();

        public event KeyPressed? OnEnterKeyPressed;
        public event KeyPressed? OnSpaceBarKeyPressed;
        public event KeyPressed? OnUpArrowKeyPressed;
        public event KeyPressed? OnDownArrowKeyPressed;
        public event KeyPressed? OnLeftArrowKeyPressed;
        public event KeyPressed? OnRightArrowKeyPressed;
        public event KeyPressed? OnEscapeKeyPressed;
        public event KeyPressed? OnAKeyPressed;
        public event KeyPressed? OnSKeyPressed;
        public event KeyPressed? OnDKeyPressed;
        public event KeyPressed? OnWKeyPressed;

        /*
        public event EventHandler OnEnterKeyPressed;
        public event EventHandler OnSpaceBarKeyPressed;
        public event EventHandler OnUpArrowKeyPressed;
        public event EventHandler OnDownArrowKeyPressed;
        public event EventHandler OnLeftArrowKeyPressed;
        public event EventHandler OnRightArrowKeyPressed;
        public event EventHandler OnEscapeKeyPressed;
        public event EventHandler OnAKeyPressed;
        public event EventHandler OnSKeyPressed;
        public event EventHandler OnDKeyPressed;
        public event EventHandler OnWKeyPressed;
        */

        public InputEventHandler()
        {

        }

        private void KeyKeyPressedCheck()
        {
            ConsoleKeyInfo keyInfo = Console.ReadKey(true);
            switch (keyInfo.Key) {
                case (ConsoleKey.Enter):
                    OnEnterKeyPressed?.Invoke();
                    break;
                case (ConsoleKey.Spacebar):
                    OnSpaceBarKeyPressed?.Invoke();
                    break;
                case (ConsoleKey.UpArrow):
                    OnUpArrowKeyPressed?.Invoke();
                    break;
                case (ConsoleKey.DownArrow):
                    OnDownArrowKeyPressed?.Invoke();
                    break;
                case (ConsoleKey.LeftArrow):
                    OnLeftArrowKeyPressed?.Invoke();
                    break;
                case (ConsoleKey.RightArrow):
                    OnRightArrowKeyPressed?.Invoke();
                    break;
                case (ConsoleKey.Escape):
                    OnEscapeKeyPressed?.Invoke();
                    break;
                case (ConsoleKey.A):
                    OnAKeyPressed?.Invoke();
                    break;
                case (ConsoleKey.S):
                    OnSKeyPressed?.Invoke();
                    break;
                case (ConsoleKey.D):
                    OnDKeyPressed?.Invoke();
                    break;
                case (ConsoleKey.W):
                    OnWKeyPressed?.Invoke();
                    break;
            }
        }
    }
}
