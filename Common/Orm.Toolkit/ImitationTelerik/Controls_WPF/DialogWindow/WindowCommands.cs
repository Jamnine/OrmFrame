using System;
using System.Windows.Input;

namespace Orm.Toolkit.Telerik.Windows.Controls
{
	/// <summary>
	/// Holds commands that can be used by a window.
	/// </summary>
	public static class WindowCommands
	{
		private static readonly int CommandsCount = CountCommands();
		private static readonly RoutedUICommand[] InternalCommands = new RoutedUICommand[CommandsCount];

		private enum CommandId : byte
		{
			/// <summary>
			/// Maximazes the window.
			/// </summary>
			Maximize = 0,

			/// <summary>
			/// Minimizes the window.
			/// </summary>
			Minimize = 1,

			/// <summary>
			/// Restores the window to Normal state.
			/// </summary>
			Restore = 5,

			/// <summary>
			/// Closes the window.
			/// </summary>
			Close = 2,

			/// <summary>
			/// Closes the window with DilogResult true.
			/// </summary>
			Confirm = 3,

			/// <summary>
			/// Closes the window with DilogResult false.
			/// </summary>
			Cancel = 4
		}

		/// <summary>
		/// Gets value that represents the maximize window command.
		/// </summary>
		/// <value>The maximize command.</value>
		public static RoutedUICommand Maximize
		{
			get
			{
				return EnsureCommand(CommandId.Maximize);
			}
		}

		/// <summary>
		/// Gets value that represents the minimize window command.
		/// </summary>
		/// <value>The minimize command.</value>
		public static RoutedUICommand Minimize
		{
			get
			{
				return EnsureCommand(CommandId.Minimize);
			}
		}

		/// <summary>
		/// Gets value that represents the restore window command.
		/// </summary>
		/// <value>The restore command.</value>
		public static RoutedUICommand Restore
		{
			get
			{
				return EnsureCommand(CommandId.Restore);
			}
		}

		/// <summary>
		/// Gets value that represents the close window command.
		/// </summary>
		/// <value>The close command.</value>
		public static RoutedUICommand Close
		{
			get
			{
				return EnsureCommand(CommandId.Close);
			}
		}

		/// <summary>
		/// Gets value that represents the Confirm window command.
		/// </summary>
		/// <value>The Confirm command.</value>
		public static RoutedUICommand Confirm
		{
			get
			{
				return EnsureCommand(CommandId.Confirm);
			}
		}

		/// <summary>
		/// Gets value that represents the Cancel window command.
		/// </summary>
		/// <value>The Cancel command.</value>
		public static RoutedUICommand Cancel
		{
			get
			{
				return EnsureCommand(CommandId.Cancel);
			}
		}

		internal static void EnsureCommandsClassLoaded()
		{
			var command = WindowCommands.Cancel;
			command = WindowCommands.Close;
			command = WindowCommands.Confirm;
			command = WindowCommands.Maximize;
			command = WindowCommands.Minimize;
			command = WindowCommands.Restore;
		}

		private static RoutedUICommand EnsureCommand(CommandId commandId)
		{
			if ((commandId < 0) || ((int) commandId >= CommandsCount))
			{
				return null;
			}
			lock (InternalCommands.SyncRoot)
			{
				if (InternalCommands[(int) commandId] == null)
				{
					var newCommand = new RoutedUICommand(
						GetUIText(commandId), commandId.ToString(), typeof(WindowCommands));

					InternalCommands[(int) commandId] = newCommand;
				}
			}

			return InternalCommands[(int) commandId];
		}

		private static int CountCommands()
		{

			return Enum.GetNames(typeof(CommandId)).Length;

		}

		private static string GetUIText(CommandId commandId)
		{
			string text = string.Empty;

			switch (commandId)
			{
				case CommandId.Maximize:
				text = SR.GetString(SR.Maximize);
				break;
				case CommandId.Minimize:
				text = SR.GetString(SR.Minimize);
				break;
				case CommandId.Restore:
				text = SR.GetString(SR.Restore);
				break;
				case CommandId.Close:
				text = SR.GetString(SR.Close);
				break;
				case CommandId.Confirm:
				text = SR.GetString(SR.Confirm);
				break;
				case CommandId.Cancel:
				text = SR.GetString(SR.Cancel);
				break;
				default:
				break;
			}

			return text;
		}
	}
}