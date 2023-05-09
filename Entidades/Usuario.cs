namespace Entidades
{
    public abstract class Usuario
    {
        private string email;
        private string contrasenia;

        //constructor
        public Usuario(string email, string contrasenia)
        {
            this.email = email;
            this.contrasenia = contrasenia;
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