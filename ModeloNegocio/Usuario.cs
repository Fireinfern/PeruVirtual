using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloNegocio
{
    public class Usuario
    {
        public List<ClassLibrary1.usuario> GetUsuarios()
        {
            using(ClassLibrary1.PeruVirtualEntities db = new ClassLibrary1.PeruVirtualEntities())
            {
                return db.usuario.ToList();
            }
        }

        public bool IsUsernameTaken(string username)
        {
            using (ClassLibrary1.PeruVirtualEntities db = new ClassLibrary1.PeruVirtualEntities())
            {
                var query = (from u in db.usuario
                             where u.nomUsuario == username
                             select new
                             {
                                 u.nomUsuario
                             });
                if (query.Any())
                {
                    return true;
                }
            }
            return false;
        }
    }
}
