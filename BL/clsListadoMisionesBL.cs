using DAL;
using Entidades;

namespace BL
{
	public class clsListadoMisionesBL
	{


		/// <summary>
		/// Método que se encarga de, si es Domingo, devolver una
		/// lista setteada a null, y si es cualquier otro día devolverá 
		/// la lista completa.
		/// </summary>
		/// <returns>
		///		si el dia de la semana es 0, devolverá null
		///		si el dia de la semana no es 0, devolverá la lista completa de misiones
		/// </returns>
		public List<clsMision> getMisionesSiNoEsDomingo()
		{
			List<clsMision> lista = null;
			if(System.DateTime.Now.DayOfWeek != 0)
			lista =  clsListadosMisiones.obtenerListadoCompleto();

			return lista;
		}

	}
}