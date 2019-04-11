// <copyright file="Table.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Unity.HelloWorld.Model
{
    public class Table
    {
        private IGame game;

        public Table(IGame game)
        {
            this.game = game;
        }

        public string GameStatus()
        {
            return this.game.Result();
        }

        public void AddPlayer()
        {
            this.game.AddPlayer();
        }

        public void RemovePlayer()
        {
            this.game.RemovePlayer();
        }

        public void Play()
        {
            this.game.Play();
        }
    }
}
