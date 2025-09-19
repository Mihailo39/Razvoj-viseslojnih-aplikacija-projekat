using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Models
{
	public class CommandManager
	{
		Stack <ICommand> undoStack;
		Stack <ICommand> redoStack;

		public void Execute(ICommand command)
		{
			throw new NotImplementedException();
		}

		public void Undo()
		{
			throw new NotImplementedException();
		}

		public void Redo()
		{
			throw new NotImplementedException();
		}
	}
}
