﻿using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using POGOProtos.Enums;

namespace PoGo.NecroBot.Logic.Model.Settings
{
    [JsonObject(Description = "")]
    public class HumanWalkSnipeFilter
    {
        [DefaultValue(300.0)]
        [Range(0, 9999)]
        [JsonProperty(Required = Required.DisallowNull, DefaultValueHandling = DefaultValueHandling.Populate)]
        public double MaxDistance { get; set; }

        [DefaultValue(1)]
        [Range(0, 9999)]
        [JsonProperty(Required = Required.DisallowNull, DefaultValueHandling = DefaultValueHandling.Populate)]
        public int Priority { get; set; }


        [DefaultValue(200.0)]
        [Range(0, 9999)]
        [JsonProperty(Required = Required.DisallowNull, DefaultValueHandling = DefaultValueHandling.Populate)]
        public double MaxWalkTimes { get; set; }


        [DefaultValue(true)]
        [Range(0, 9999)]
        [JsonProperty(Required = Required.DisallowNull, DefaultValueHandling = DefaultValueHandling.Populate)]
        public bool CatchPokemonWhileWalking { get; set; }


        [DefaultValue(true)]
        [JsonProperty(Required = Required.DisallowNull, DefaultValueHandling = DefaultValueHandling.Populate)]
        public bool SpinPokestopWhileWalking { get; set; }


        public HumanWalkSnipeFilter(double maxDistance, double maxWalkTimes, int priority, bool catchPokemon, bool spinPokestop)
        {
            this.MaxDistance = maxDistance;
            this.MaxWalkTimes = maxWalkTimes;
            this.Priority = priority;
            this.CatchPokemonWhileWalking = catchPokemon;
            this.SpinPokestopWhileWalking = spinPokestop;
        }

        internal static Dictionary<PokemonId, HumanWalkSnipeFilter> Default()
        {
            return new Dictionary<PokemonId, HumanWalkSnipeFilter>
            {
                {PokemonId.Magikarp, new HumanWalkSnipeFilter(300, 200, 10, true, true)},
                {PokemonId.Eevee, new HumanWalkSnipeFilter(500, 200, 10, true, true)},
                {PokemonId.Electabuzz, new HumanWalkSnipeFilter(1500, 600, 2, true, true)},
                {PokemonId.Dragonite, new HumanWalkSnipeFilter(3000, 900, 1, false, false)},
                {PokemonId.Dragonair, new HumanWalkSnipeFilter(3000, 900, 1, false, false)},
                {PokemonId.Dratini, new HumanWalkSnipeFilter(2000, 900, 1, false, false)},
                {PokemonId.Charizard, new HumanWalkSnipeFilter(3000, 900, 1, false, false)},
                {PokemonId.Snorlax, new HumanWalkSnipeFilter(3000, 900, 1, false, false)},
                {PokemonId.Lapras, new HumanWalkSnipeFilter(3000, 900, 1, false, false)},
                {PokemonId.Exeggutor, new HumanWalkSnipeFilter(1500, 600, 1, false, true)},
                {PokemonId.Vaporeon, new HumanWalkSnipeFilter(1800, 800, 2, false, false)},
                {PokemonId.Flareon, new HumanWalkSnipeFilter(1800, 800, 2, false, false)},
                {PokemonId.Scyther, new HumanWalkSnipeFilter(1000, 800, 3, false, false)},
                {PokemonId.Beedrill, new HumanWalkSnipeFilter(1000, 800, 3, false, false)},
                {PokemonId.Chansey, new HumanWalkSnipeFilter(1000, 800, 2, false, false)},
                {PokemonId.Clefable, new HumanWalkSnipeFilter(1000, 800, 3, false, false)},
                {PokemonId.Golbat, new HumanWalkSnipeFilter(200, 800, 6, true, true)},
                {PokemonId.Jynx, new HumanWalkSnipeFilter(1200, 800, 4, true, true)},
                {PokemonId.Kangaskhan, new HumanWalkSnipeFilter(800, 800, 4, true, true)},
                {PokemonId.Gyarados, new HumanWalkSnipeFilter(1800, 800, 2, false, false)}  
            };
        }
    }
}
