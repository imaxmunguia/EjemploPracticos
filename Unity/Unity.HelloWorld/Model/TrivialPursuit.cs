// <copyright file="TrivialPursuit.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Unity.HelloWorld.Model
{
    public class TrivialPursuit : IGame
    {
        private string status;

        public TrivialPursuit()
        {
            this.Name = "Trivial Pursuit";
            this.CurrentPlayers = 0;
            this.MinPlayers = 2;
            this.MaxPlayers = 8;
            this.status = "Sin juego activo";
        }

        public string Name { get; set; }

        public int CurrentPlayers { get; set; }

        public int MinPlayers { get; set; }

        public int MaxPlayers { get; set; }

        public void AddPlayer()
        {
            this.CurrentPlayers++;
        }

        public void RemovePlayer()
        {
            this.CurrentPlayers--;
        }

        public void Play()
        {
            if ((this.CurrentPlayers > this.MaxPlayers) || (this.CurrentPlayers < this.MinPlayers))
            {
                this.status = string.Format("{0}: No es posible jugar con {1} jugadores.", this.Name, this.CurrentPlayers);
            }
            else
            {
                this.status = string.Format("{0}: Jugando con {1} jugadores.", this.Name, this.CurrentPlayers);
            }
        }

        public string Result()
        {
            return this.status;
        }
    }
}
