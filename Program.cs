﻿using System.Runtime.ConstrainedExecution;

//*/Si vuole progettare un sistema per la gestione di una biblioteca.
//Gli utenti si possono registrare al sistema, fornendo:
//-cognome
//- nome
//- email
//- password
//- recapito telefonico
//Gli utenti registrati possono prendere in prestito dei documenti che sono di vario tipo (libri, DVD).
//I documenti sono caratterizzati da:
//-un codice identificativo di tipo stringa
//- titolo
//- anno
//- settore (storia, matematica, economia, …)
//-uno scaffale in cui è posizionato
//- un autore (Nome, Cognome)
//Per i libri si ha in aggiunta il numero di pagine, mentre per i dvd la durata.
//L’utente deve poter eseguire delle ricerche per codice o per titolo e, eventualmente, prendere in prestito registrando il periodo (Dal/Al) del prestito e il documento.
//Deve essere possibile effettuare la ricerca dei prestiti dato nome e cognome di un utente.
//Creiamo anche una classe Biblioteca che contiene la lista dei documenti, la lista degli utenti e la lista dei prestiti.
////Contiene inoltre i metodi per le ricerche e per l’aggiunta dei documenti, utenti e prestiti. */

using static Biblioteca;


var users = new List<User>();
var user1 = new User("Mattia", "Rossi", "mattiarossi@gmail.com", "qwerty", "1234567890");
var user2 = new User("Giuseppe", "Verdi", "giuseppeverdi@gmail.com", "qwerty", "1234567890");
var user3 = new User("Michele", "Bianchi", "michelebainchi@gmail.com", "qwerty", "1234567890");
var user4 = new User("Alessandro", "Aranconi", "alessandroarancioni@gmail.com", "qwerty", "1234567890");
var user5 = new User("Claudio", "Blu", "claudioblu@gmail.com", "qwerty", "1234567890");

users.Add(user1);
users.Add(user2);
users.Add(user3);
users.Add(user4);
users.Add(user5);


var books = new List<Book>();
var book1 = new Book("1984", 200, "fantascienza", "A99", new[] { "George", "Orwell" }, 2000);
var book2 = new Book("Centanni di solitudine", 300, "romanzo", "C3", new[] { "Gabriel Garcia", "Marquez" }, 4000);
var book3 = new Book("Il Decamerone", 100, "finanza", "C09", new[] { "Giovanni", "Boccaccio" }, 3500);

books.Add(book1);
books.Add(book2);
books.Add(book3);


var DVDs = new List<DVD>();
var DVD1 = new DVD("Il padrino", 1972, "fantascienza", "D57", new[] { "Francis", "Coppola" }, 100);
var DVD2 = new DVD("Il Signore Degli Anelli", 2001, "fantasy", "C69", new[] { "Steven", "Spielberg" }, 300);
var DVD3 = new DVD("I predatori dell'arca perduta", 1981, "fantasy", "C69", new[] { "Steven", "Spielberg" }, 300);

DVDs.Add(DVD1);
DVDs.Add(DVD2);
DVDs.Add(DVD3);


Console.WriteLine("Lista Utenti: ");
Console.WriteLine(ShowUsers(users));

Console.WriteLine("Lista Libri: ");
Console.WriteLine(ShowBooks(books));

Console.WriteLine("Lista DVDs: ");
Console.WriteLine(ShowDVDs(DVDs));

string ShowUsers(List<User> list)
{
    return string.Join(Environment.NewLine, list).ToString();
}
string ShowBooks(List<Book> list)
{
    return string.Join(Environment.NewLine, list).ToString();
}
string ShowDVDs(List<DVD> list)
{
    return string.Join(Environment.NewLine, list).ToString();
}