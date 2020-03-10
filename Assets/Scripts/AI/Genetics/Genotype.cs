namespace AI.Genetics {
    public class Genotype {
        public float Fitness { get; set; }
        public float[] Values { get; }
        
        public Genotype(int numValues) {
            Values = new float[numValues];
        }
    }
}