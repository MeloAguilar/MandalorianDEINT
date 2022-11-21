using DAL;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.ManejadoraBL
{
	public class clsManejadoraMisionBL
	{

		public clsMision getMisionPorId(int id)
		{
			clsListadoMisionesBL bl = new clsListadoMisionesBL();
			return DAL.clsManejadoraMision.obtenerMisionPorId(bl.obtenerListadoCompletoSiNoEsDomingo(),id) ;
		}
	}
}
