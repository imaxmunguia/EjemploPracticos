// <copyright file="IGame.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Unity.HelloWorld.Model
{
    public interface IGame
    {
        string Name { get; }

        int CurrentPlayers { get; }

        int MinPlayers { get; }

        int MaxPlayers { get; }

        void AddPlayer();

        void RemovePlayer();

        void Play();

        string Result();
    }
}