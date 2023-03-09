using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PorfolioWeb_AccesoDatos.Data.Repository.IRepository
{
    public interface IContenedorTrabajo:IDisposable
	{
		//Aqui se deden ir agregando los diferentes repositorios
		ISkillRepository Skills { get; }
		void Save();
		//Ir a contenedorTrabajo 
	}
}
