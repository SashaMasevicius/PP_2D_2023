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

    }
}