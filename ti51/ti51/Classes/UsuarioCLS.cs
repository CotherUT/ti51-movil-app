using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace TI51.Clases
{
    public class UsuarioCLS:INotifyPropertyChanged
    {
        //Valores temporales
        public string _usuario { get; set; }
        public string _password { get; set; }

        public string usuario
        {
            get
            {
                return _usuario;
            }

            set
            {
                if(this._usuario!= value)
                {
                    this._usuario= value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(this.usuario)));
                }
            }
        }


        public string password
        {
            get
            {
                return _password;
            }

            set
            {
                if(this._password!= value)
                {
                    this._password= value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(this.password)));
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
