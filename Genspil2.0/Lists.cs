﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genspil2._0
{
    internal class Lists
    {
        public static void ShowGamesTitle()
        {
            Console.Clear();
            Console.WriteLine("Lagerliste sortetet efter spillets navn.\n----------------------------------------\n");
            var games = Game.GetGames();
            var sortedGames = games.OrderBy(g => g.Title).ToList();
            foreach (var g in sortedGames)
            {
                Console.WriteLine($"Spil: {g.Title}\nUdgave: {g.Version}\nGenre: {g.Genre}\nMax antal spillere: {g.ParticipantGame}\nMin. aldersgrænse: {g.AgePlayerGame}\nStand: {g.ConditionGame}\nPris: {g.PriceGame}\nAntal: {g.AmountGame}");
                Console.WriteLine("-----------------------------------");
            }
            Console.WriteLine("Indtast vilkårlig tast for at blive sendt til hovedmenuen.");
            Console.ReadLine();
        }
        public static void ShowGamesGenre()
        {
            Console.Clear();
            Console.WriteLine("Lagerliste sorteret efter genre.\n--------------------------------");
            var games = Game.GetGames();
            var sortedGenre = games.OrderBy(g => g.Genre).ToList();
            foreach (var g in sortedGenre)
            {
                Console.WriteLine($"Spil: {g.Title}\nUdgave: {g.Version}\nGenre: {g.Genre}\nMax antal spillere: {g.ParticipantGame}\nMin. aldersgrænse: {g.AgePlayerGame}\nStand: {g.ConditionGame}\nPris: {g.PriceGame}\nAntal: {g.AmountGame}");
                Console.WriteLine("-----------------------------------");
            }
            Console.WriteLine("Indtast vilkårlig tast for at blive sendt til hovedmenuen.");
            Console.ReadLine();
        }
        public static void ShowRequests()
        {
            Console.Clear();
            Console.WriteLine("Liste over alle forespørgsler.\n--------------------------------------");
            var requests = Request.GetRequests();
            var sortedRequests = requests.OrderBy(r => r.Title).ToList();
            foreach (var r in sortedRequests)
            {
                Console.WriteLine($"Kunde: {r.Name}\nEmail: {r.Email}\nTelefon: {r.Phone}\nTitel: {r.Title}\nUdgave: {r.Version}\nØnsket stand: {r.Condition}\n");
                Console.WriteLine("-----------------------------------");
            }
            Console.WriteLine("Indtast vilkårlig tast for at blive sendt til hovedmenuen.");
            Console.ReadLine();
        }
    }
}
