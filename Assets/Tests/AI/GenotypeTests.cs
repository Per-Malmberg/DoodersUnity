using System.Collections;
using System.Collections.Generic;
using AI;
using AI.Genetics;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests {
    public class GenotypeTests {
        // A Test behaves as an ordinary method
        [Test]
        public void GenotypeIsCreatedWithRightNumberOfValues() {
            // Use the Assert class to test conditions
            var genotype = new Genotype(10);
            Assert.AreEqual(10, genotype.Values.Length);
        }
    }
}