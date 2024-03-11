using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO_1
{
    class Dusuario
    {
        public string _usuario;
        public string _password;

        public string get_usuario()
        {
            return _usuario;
        }

        public string get_password()
        {
            return _password;
        }

        public void set_usuario(string value)
        {
            this._usuario = value;
        }

        public void set_password(string value)
        {
            this._password = value;
        }
    }
}


