using System.Collections;
using System.Collections.Generic;
using AI;
using AI.Genetics;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests {
    public class ParentSelectorTests {
        [Test]
        public void DifferentParentsAreSelected() {
            var pop = new Genotype[] {
                new Genotype(10), new Genotype(5), new Genotype(12), new Genotype(23)
            };
            var selector = new ParentSelector();
            selector.SelectParents(pop, out var parent1, out var parent2);
            Assert.AreNotSame(parent1, parent2);
        }
    }
}