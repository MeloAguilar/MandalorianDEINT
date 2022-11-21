using MandalorianUI.Models;
using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using BL;
using BL.ManejadoraBL;
using System.Collections.ObjectModel;

namespace MandalorianUI.ViewModels
{
	public class clsIndexVM : clsVMBase
	{
		#region Atributos
		private clsListadoMisionesBL bl;

		private clsMision misionSeleccionada;

		private ObservableCollection<clsMision> misiones;

		private bool datosMisionEsVisible;

		private DelegateCommand mostrarMisionCommand;

		#endregion

		#region Propiedades
		public bool DatosMisionEsVisible { 
			get 
			{ 
				return datosMisionEsVisible; 
			} 
			set
			{
				datosMisionEsVisible = value;
				NotifyPropertyChanged("DatosMisionEsVisible");
			}
		}
		
	

		public clsMision MisionSeleccionada
		{
			get => misionSeleccionada;

			set
			{
				if (misionSeleccionada != value)
				{
					misionSeleccionada = value;
					mostrarMisionCommand.RaiseCanExecuteChanged();
				}
			}
		}

		public ObservableCollection<clsMision> Misiones
		{
			get => misiones;
		}


	public DelegateCommand MostrarMisionesComand
		{
			get
			{
				mostrarMisionCommand = new DelegateCommand(MostrarMisionCommand_Executed, MostrarMisionCommand_CanExecute);
				return mostrarMisionCommand;
			}
		}
		#endregion

		#region Contructores

		public clsIndexVM()
		{
			datosMisionEsVisible = false;
			misionSeleccionada = null;
			bl = new clsListadoMisionesBL();
			misiones = new ObservableCollection<clsMision>(bl.obtenerListadoCompletoSiNoEsDomingo());

		}

		#endregion
	
		


		#region CommandProperties
		private void MostrarMisionCommand_Executed()
		{
			DatosMisionEsVisible = true;

			NotifyPropertyChanged("MisionSeleccionada");
		}



		private bool MostrarMisionCommand_CanExecute()
		{
			var visibilidadBoton = true;
			if (misionSeleccionada == null)
			{
				visibilidadBoton = false;
			}
			return visibilidadBoton;
		}
		#endregion

	}


}
