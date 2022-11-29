namespace ExercVet
{
    class Info
    {
        public int NumeroQuarto { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }

        public Info(string nome, string email)
        {
            Nome = nome;
            Email = email;
        }

        public override string ToString()
        {
            return Nome + ", " + Email;
        }

    }
}
