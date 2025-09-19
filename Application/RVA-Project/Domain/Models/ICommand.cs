using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Models
{
	public interface ICommand
	{
		void Execute();

		void Undo();
	}
}
