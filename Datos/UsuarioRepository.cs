using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{

    public class UsuarioRepository
    {


        public List<usuario> GetUsuarios()
        {
            using (PeruVirtualEntities db = new PeruVirtualEntities())
            {
                return db.usuario.ToList();
            }
        }

        public bool InsertarUsuario(usuario user)
        {
            string passEncrypt = Encriptar(user.contrasena);
            user.contrasena = passEncrypt;
            using (PeruVirtualEntities db = new PeruVirtualEntities())
            {
                try
                {
                    db.usuario.Add(user);
                    Console.WriteLine(user.nombre);
                    Console.WriteLine(user.username);
                    Console.WriteLine(user.correo);
                    Console.WriteLine(user.contrasena);
                    db.SaveChanges();

                    return true;
                }
                catch(Exception ex)
                {

                }
                return false;
            }
        }
        /// Encripta una cadena
        public string Encriptar( string _cadenaAencriptar)
        {
            string result = string.Empty;
            byte[] encryted = Encoding.Unicode.GetBytes(_cadenaAencriptar);
            result = Convert.ToBase64String(encryted);
            return result;
        }

 

        /*static void Main(string[] args)
        {
            using (PeruVirtualEntities db = new PeruVirtualEntities())
            {
                Console.WriteLine(db.usuario.ToList());
            }
        }*/

    }

}
