using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace AI.Genetics {
    public class ParentSelector {
        public void SelectParents(IEnumerable<Genotype> pop, out Genotype parent1, out Genotype parent2) {
            parent1 = SelectParent(pop);
            var p1Tmp = parent1;
            parent2 = SelectParent(pop.Where(x => x != p1Tmp));
        }

        private Genotype SelectParent(IEnumerable<Genotype> pop) {
            var champions = new List<Genotype>();
            for (var i = 0; i < pop.Count() / 4; i++) {
                var potential = pop.Where(x => !champions.Contains(x));
                champions.Add(potential.ElementAt(UnityEngine.Random.Range(0, potential.Count())));
            }

            return champions.OrderBy(x => x.Fitness).Last();
        }
    }
}