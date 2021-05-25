﻿using System.Collections.Generic;
using UnityEngine;
using GeneticAlgorithmForSpecies.Structures;

namespace GeneticAlgorithmForSpecies.Genes
{
    [System.Serializable]
    public class GeneContainer
    {
        [SerializeField] private ValueContainer<Gene.Type, Gene> genes;

        public Dictionary<string, Gene> Data { get => genes.Data; }

        public Gene this[string key] { get => GetGene(key); /*set => SetValue(key, value);*/ }
        
        public GeneContainer()
        {
            genes = new ValueContainer<Gene.Type, Gene>();

            foreach (Gene.Type type in (Gene.Type[])System.Enum.GetValues(typeof(Gene.Type)))
            {
                genes[type] = new Gene();
            }
        }

        public GeneContainer(GeneContainer other)
        {
            genes = new ValueContainer<Gene.Type, Gene>(other.genes);
        }

        public Gene GetGene(string name)
        {
            Gene.Type type = (Gene.Type) System.Enum.Parse(typeof(Gene.Type), name);
            return genes[type];
        }
    }
}