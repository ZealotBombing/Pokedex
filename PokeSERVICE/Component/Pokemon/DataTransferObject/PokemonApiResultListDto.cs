﻿using PokeDataSource.Component.Pokemon.DataTransferObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonIntegration.Component.Pokemon.DataTransferObject
{
    public class PokemonApiResultListDto
    {
        public int count {  get; set; }
        public string next {  get; set; }
        public string previous { get; set; }
        public List<PokemonApiResultDto> results { get; set; }
    }
}
