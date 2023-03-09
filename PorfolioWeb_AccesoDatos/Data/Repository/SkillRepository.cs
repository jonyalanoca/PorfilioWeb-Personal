using PorfolioWeb.Data;
using PorfolioWeb_AccesoDatos.Data.Repository.IRepository;
using PorfolioWeb_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PorfolioWeb_AccesoDatos.Data.Repository
{
    internal class SkillRepository : Repository<Skill>, ISkillRepository
    {
        private readonly ApplicationDbContext _db;
        public SkillRepository(ApplicationDbContext context) : base(context)
        {
            _db = context;
        }
        public void update(Skill skill)
        {
            var objeto = _db.Skills.FirstOrDefault(s => s.Id == skill.Id);
            objeto.Nombre=skill.Nombre;
            objeto.Nivel = skill.Nivel;
            objeto.Descripcion = skill.Descripcion;
            objeto.UrlImagen=skill.UrlImagen;
        }
    }
}
