using PorfolioWeb.Data;
using PorfolioWeb_AccesoDatos.Data.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PorfolioWeb_AccesoDatos.Data.Repository
{
    public class ContenedorTrabajo : IContenedorTrabajo
    {
        private readonly ApplicationDbContext _db;
        public ISkillRepository Skills { get; private set; }


        public ContenedorTrabajo(ApplicationDbContext db)
        {
            _db = db;
			Skills = new SkillRepository(_db);
		}
        
       

        public void Dispose()
        {
            _db.Dispose();//metodo especial que permite liberar memoria, procesos indesusos
        }

        public void Save()
        {
            _db.SaveChanges();
        }

        //Fin ahora crear su controlador correspondiente
    }
}
