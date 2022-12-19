
namespace ExercMaiorIdade
{
    
        class Pessoa
        {
            public string Name { get; set; }
            public int Age { get; set; }

            public Pessoa(string name, int age)
            {
               Name = name;
               Age = age;
            }


            public string name
            {
            get { return Name; }
            set { Name = value.ToUpper(); }
            }

            public int idade
            {
            get { return idade; }
            set { idade = value; }
            }
           

          public Pessoa()
          {
         
          }



        public void ExibirDados()
            {
            Console.WriteLine("Nome: "+Name);
            Console.WriteLine("Idade: "+Age);
            }

        }


}

     

