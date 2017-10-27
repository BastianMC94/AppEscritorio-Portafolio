using GUI;
using System.Windows.Forms;

namespace System
{
	static class Program
	{
		/// <summary>
		/// Punto de entrada principal para la aplicación.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			//Si quieres probar los otros .cs sólo cambia el GUI.Login por GUI.Menu
			Application.Run(new GUI.Login());
		}
	}
}