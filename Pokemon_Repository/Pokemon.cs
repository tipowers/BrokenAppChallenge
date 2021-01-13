﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon_Repository
{
    public enum PokemonType
    {
        Normal = 1,
        Grass,
        Fire,
        Water,
        Electric,
        Ice,
        Bug,
        Ground,
        Rock,
        Fighting,
        Psychic,
        Ghost,
        Dark,
        Fairy,
        Dragon,
        None
    }

    public class Pokemon
    {
        public string PokemonSpeciesName { get; set; }
        public string PokemonNickName { get; set; }
        public int Level { get; set; }
        public PokemonType PokemonType { get; set; }
        public PokemonType SecondaryType { get; set; }
        public string MoveOne { get; set; }
        public string MoveTwo { get; set; }
        public string MoveThree { get; set; }
        public string MoveFour { get; set; }

        public Pokemon(string speciesName, string NickName, int level, PokemonType pokemonType, PokemonType secondaryType, string moveOne, string moveTwo, string moveThree, string moveFour)
        {
            //TeamPosition = teamPosition;
            PokemonSpeciesName = speciesName;
            PokemonNickName = NickName;
            Level = level;
            PokemonType = pokemonType;
            SecondaryType = secondaryType;
            MoveOne = moveOne;
            MoveTwo = moveTwo;
            MoveThree = moveThree;
            MoveFour = moveFour;
        }
    }
}
