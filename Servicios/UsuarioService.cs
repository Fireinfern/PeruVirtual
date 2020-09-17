using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios
{
    public class UsuarioService
    {
        public static int AccesClient(string nombreUsuario, string contrasenia)
        {
            using (ClassLibrary1.PeruVirtualEntities db = new ClassLibrary1.PeruVirtualEntities())
            {
                var query = (from u in db.usuario
                             where u.nomUsuario == nombreUsuario && u.contrasenia == contrasenia
                             select new
                             {
                                 u.idCliente,
                                 u.idUsuario
                             });
                if (query.Any())
                {
                    return query.Single().idCliente;
                }
            }
            return 0;
        }
        public static void CreateUser(int idcliente, string nombreUsuario, string contrasenia)
        {
            using (ClassLibrary1.PeruVirtualEntities db = new ClassLibrary1.PeruVirtualEntities())
            {
                ClassLibrary1.usuario user = new ClassLibrary1.usuario{
                                                                        idCliente = idcliente,
                                                                        nomUsuario = nombreUsuario,
                                                                        contrasenia = contrasenia
                                                                        };
                db.usuario.Add(user);
                db.SaveChanges();
            }
        }
    }
}
