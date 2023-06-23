namespace Entidades
{
    public abstract class Usuario
    {
        private string email;
        private string contrasenia;
        private int tipoDeUsuario;

        //constructor
        public Usuario(string email, string contrasenia)
        {
            this.email = email;
            this.contrasenia = contrasenia;
        }


        protected Usuario(string email, string contrasenia, int tipoDeUsuario)
        {
            this.email = email;
            this.contrasenia = contrasenia;
            this.tipoDeUsuario = tipoDeUsuario;
        }

        //propiedad
        public string Email
        {
            get => email;

        }
        public string Contrasenia
        {
            get => contrasenia;
        }
        public int TipoDeUsuario { get => tipoDeUsuario; set => tipoDeUsuario = value; }

        /// <summary>
        /// creo mensaje para iniciar sesion
        /// </summary>
        /// <returns></returns>
        public virtual string crearMensajeBienvenido()
        {
            return $"El usuario {Email} ha iniciado sesión.";
        }
    }
}