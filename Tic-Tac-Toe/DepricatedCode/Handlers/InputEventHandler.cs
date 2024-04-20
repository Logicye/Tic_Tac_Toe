using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic_Tac_Toe.DepricatedCode.Handlers
{
    internal class InputEventHandler
    {
        public delegate void KeyPressed(ConsoleKeyInfo keyInfo);
        public delegate void KeyPressedSpecific();

        public static event KeyPressed? OnKeyPressed;

        public event KeyPressedSpecific? OnEnterKeyPressed;
        public event KeyPressedSpecific? OnUpArrowKeyPressed;
        public event KeyPressedSpecific? OnDownArrowKeyPressed;
        public event KeyPressedSpecific? OnLeftArrowKeyPressed;
        public event KeyPressedSpecific? OnRightArrowKeyPressed;
        //public event KeyPressedSpecific? OnSpaceBarKeyPressed;
        //public event KeyPressedSpecific? OnAKeyPressed;
        //public event KeyPressedSpecific? OnSKeyPressed;
        //public event KeyPressedSpecific? OnDKeyPressed;
        //public event KeyPressedSpecific? OnWKeyPressed;
        public event KeyPressedSpecific? OnEscapeKeyPressed;

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
            while (true)
            {

            }
        }

        public static void KeyPressedCheck()
        {
            ConsoleKeyInfo keyInfo;
            while (true)
            {
                keyInfo = Console.ReadKey(true);
                OnKeyPressed?.Invoke(keyInfo);
            }
        }

        public void KeyPressedSpecificCheck()
        {
            ConsoleKeyInfo keyInfo;
            do
            {
                keyInfo = Console.ReadKey(true);
                if (keyInfo.Key == ConsoleKey.Enter)
                {
                    Debug.WriteLine("Enter");
                    OnEnterKeyPressed?.Invoke();
                }
                else if (keyInfo.Key == ConsoleKey.UpArrow)
                {
                    OnUpArrowKeyPressed?.Invoke();
                }
                else if (keyInfo.Key == ConsoleKey.DownArrow)
                {
                    OnDownArrowKeyPressed?.Invoke();
                }
                else if (keyInfo.Key == ConsoleKey.LeftArrow)
                {
                    OnLeftArrowKeyPressed?.Invoke();
                }
                else if (keyInfo.Key == ConsoleKey.RightArrow)
                {
                    OnRightArrowKeyPressed?.Invoke();
                }
                else if (keyInfo.Key == ConsoleKey.Escape)
                {
                    OnEscapeKeyPressed?.Invoke();
                }
                /*
                switch (keyInfo.Key)
                {
                    case (ConsoleKey.Enter):
                        OnEnterKeyPressed?.Invoke();
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
                        //case (ConsoleKey.A):
                        //    OnAKeyPressed?.Invoke();
                        //    break;
                        //case (ConsoleKey.S):
                        //    OnSKeyPressed?.Invoke();
                        //    break;
                        //case (ConsoleKey.D):
                        //    OnDKeyPressed?.Invoke();
                        //    break;
                        //case (ConsoleKey.W):
                        //    OnWKeyPressed?.Invoke();
                        //    break;
                        //case (ConsoleKey.Spacebar):
                        //    OnSpaceBarKeyPressed?.Invoke();
                        //    break;
                }
                */
            } while (true);
        }
    }
}
