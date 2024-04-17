using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic_Tac_Toe.Handlers
{
	internal interface IConsoleEvents
	{
		void Register();
		void Unregister();
		void OnKeyPressed(ConsoleKey key);
	}
}
