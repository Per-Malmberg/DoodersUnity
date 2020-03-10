using System;
using System.Collections.Generic;
using MathNet.Numerics.LinearAlgebra;

namespace NeuralNetwork {
	public class NeuralNetwork {
		private float LearningRate = 0.1f;

		private List<Matrix<float>> _weights = new List<Matrix<float>>();
		private List<Matrix<float>> _output = new List<Matrix<float>>();

		public NeuralNetwork(int[] layers) {
			for(int i = 0;i < layers.Length - 1;i++) {
				_weights.Add(Matrix<float>.Build.Random(layers[i + 1], layers[i]));
			}
		}

		public Matrix<float> Predict(Matrix<float> input) {
			//TODO: add bias
			_output.Clear();
			_output.Add(input);
			Matrix<float> output = input;
			for(int i = 0;i < _weights.Count;i++) {
				output = Sigmoid(_weights[i] * output);
				_output.Add(output);
			}
			return output;
		}

		public void Train(Matrix<float> error) {
			for(int i = _weights.Count - 1;i >= 0;i--) {
				var gradient = error.
					PointwiseMultiply((1 - _output[i + 1])).
					PointwiseMultiply(_output[i + 1]) * 
					_output[i].Transpose(); 
				_weights[i] -= LearningRate * gradient;
				error = _weights[i].Transpose() * error;
			}
		}

		private Matrix<float> Sigmoid(Matrix<float> matrix) {
			for(int i = 0;i < matrix.RowCount;i++) {
				for(int j = 0;j < matrix.ColumnCount;j++) {
					matrix[i, j] = 1f / (1f + MathF.Exp(matrix[i, j]));
				}
			}
			return matrix;
		}
	}
}