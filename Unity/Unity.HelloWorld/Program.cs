// <copyright file="Program.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>
namespace Unity.HelloWorld
{
    using System;
    using Microsoft.Practices.Unity;
    using Unity.HelloWorld.Model;

    class Program
    {
        static void Main(string[] args)
        {
            // Declaramos un contenedor Unity
            var unityContainer = new UnityContainer();

            // Registramos IGame para que cuando se detecte la dependencia
            // proporcione una instancia de TrivialPursuit
            // Inyectamos una propiedad cuando se resuelva la dependencia
            InjectionProperty injectionProperty = new InjectionProperty("Name", "Trivial Pursuit Genus Edition");
            unityContainer.RegisterType<IGame, TrivialPursuit>(injectionProperty);

            var table = unityContainer.Resolve<Table>();
            table.AddPlayer();
            table.AddPlayer();
            table.AddPlayer();
            table.Play();
            Console.WriteLine(table.GameStatus());
            Console.ReadLine();

            var table2 = unityContainer.Resolve<Table>(new ParameterOverride("game", new TicTacToe()));
            table2.AddPlayer();
            table2.AddPlayer();
            table2.Play();
            Console.WriteLine(table2.GameStatus());
            Console.ReadLine();
        }
    }
}
