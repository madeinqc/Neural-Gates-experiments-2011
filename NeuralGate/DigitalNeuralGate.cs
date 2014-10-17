using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BrainNet.NeuralFramework;
using System.Collections;

namespace NeuralGate
{
    public class DigitalNeuralGate
    {
        private NeuralNetwork network;

        public DigitalNeuralGate()
        {
            BackPropNetworkFactory factory = new BackPropNetworkFactory();
            ArrayList layers = new ArrayList();

            layers.Add(2);
            layers.Add(2);
            layers.Add(1);

            network = (NeuralNetwork)factory.CreateNetwork(layers);
        }

        public void Train(int input1, int input2, int output)
        {
            TrainingData td = new TrainingData();

            td.Inputs.Add(input1);
            td.Inputs.Add(input2);

            td.Outputs.Add(output);

            network.TrainNetwork(td);
        }

        public double Run(int input1, int input2)
        {
            ArrayList inputs = new ArrayList();

            inputs.Add(input1);
            inputs.Add(input2);

            ArrayList outputs = network.RunNetwork(inputs);

            return (double)outputs[0];
        }

        public void Save(string filename)
        {
            NetworkSerializer ns = new NetworkSerializer();
            ns.SaveNetwork(filename, network);
        }

        public void Load(string filename)
        {
            NetworkSerializer ns = new NetworkSerializer();
            INeuralNetwork networkInterface = (INeuralNetwork)network;
            ns.LoadNetwork(filename, ref networkInterface);
            network = (NeuralNetwork)networkInterface;
        }
    }
}
