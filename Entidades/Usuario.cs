namespace Entidades
{
    public abstract class Usuario
    {
        private string email;
        private string contrasenia;

        public Usuario(string email, string contrasenia)
        {
            this.email = email;
            this.contrasenia = contrasenia;
        }

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