using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MandalorianUI.ViewModels
{
	public class clsIndexVM
	{
		private clsMision misionSeleccionada;
		private List<clsMision> misiones;
		private bool datosMisionEsVisible;
		private Command cambioDatosCommand;

		public Command CambioDatosCommand
		{
			get { return cambioDatosCommand; }
		}


		public clsMision MisionSeleccionada
		{
			get => misionSeleccionada;

			set
			{
				if (misionSeleccionada != value)
				{
					misionSeleccionada = value;

				}
			}
		}

		public List<clsMision> Misiones
		{
			get => misiones;
			set
			{
				misiones = value;
			}
		}

		public clsIndexVM()
		{
		}
	}

	
}
