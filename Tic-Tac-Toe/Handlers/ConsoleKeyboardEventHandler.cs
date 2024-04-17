using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTestingBase
{
	static class ConsoleKeyboardEventHandler
	{
		public delegate void KeyboardEvent(ConsoleKey key);
		public static event KeyboardEvent? KeyPressed;

		private static CancellationTokenSource _cancellationTokenSource = new CancellationTokenSource();
		public static void Start()
		{
			_cancellationTokenSource = new CancellationTokenSource();		

			while (!_cancellationTokenSource.IsCancellationRequested)
			{
				ConsoleKeyInfo keyInfo = Console.ReadKey(true);
				KeyPressed?.Invoke(keyInfo.Key);
			}
			Debug.WriteLine("Event Handler Finished Execution");
		}

		public static void Stop()
		{
			_cancellationTokenSource.Cancel();
		}
	}
}
