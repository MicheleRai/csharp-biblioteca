using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    public class User
    {
        string cognome;
        string nome;
        string email;
        string password;
        string cell;
        bool registrato;

        public User(string cognome, string nome, string email, string password, string cell, bool registrato) 
        {
            this.cognome = cognome;
            this.nome = nome;
            this.email = email;
            this.password = password;
            this.cell = cell;
            this.registrato = registrato;
        }

        bool Registrazione() 
        {
            if (password != "")
            {
                registrato = true; 
            }
            else
            {
                registrato = false;
            }
            return registrato;
        } 
    }
}
