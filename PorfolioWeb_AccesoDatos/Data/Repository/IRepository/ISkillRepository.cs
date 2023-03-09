using PorfolioWeb_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PorfolioWeb_AccesoDatos.Data.Repository.IRepository
{
    public interface ISkillRepository:IRepository<Skill>
    {
        void update (Skill skill);
    }
}
