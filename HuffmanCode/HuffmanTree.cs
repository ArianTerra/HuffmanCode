using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;


namespace HuffmanCode
{
    public partial class HuffmanTree
    {
        // Basic data.
        public Dictionary<string, int> Frequencies = new Dictionary<string, int>();
        public Dictionary<string, string> CodeNames = null;
        public int AggreagtionLen = 0;


        // Represents tree, is in use by the algorithm.
        private readonly List<Node> nodes = new List<Node>();
        public Node Root { get; set; }

        //-----------------\\
        // RESULT           \\
        // ARE              //
        // HERE            //
        //----------------//

        public Dictionary<string, Tuple<string, string, double>> Result = new Dictionary<string, Tuple<string, string, double>>();
        // aggregated symbol - code name - code - frequancy;


        //---------------------------------------------\\
        // Run Build() method, then use Result field.   \\
        //----------------------------------------------//

        // nouse = false is error-prone.
        public void Build(string source, int aggregated, bool nouse = false)
        {
            AggreagtionLen = aggregated;

            HashSet<string> Alphabet = new HashSet<string>();
            
            for (var i = 0; i < source.Length; i++)
            {
                if (!Alphabet.Contains(source[i].ToString()))
                    Alphabet.Add(source[i].ToString());
            }

            // These items are gonna explode!
            List<string> AggregatedSymbols = Alphabet.ToList();

            // This way copy is done (it contains exploded symbols).
            List<string> AggregatingSymbols = AggregatedSymbols.Select(x => x).ToList();

            for (int power = 1; power < aggregated; power++)
            {
                int ing = AggregatingSymbols.Count;
                int ed = AggregatedSymbols.Count;
                for (int limit = 0; limit < ing; limit++)
                {
                    for (int duplicate = 0; duplicate < ed; duplicate++)
                    {
                        AggregatingSymbols.Add(AggregatingSymbols[limit] + AggregatedSymbols[duplicate]);
                    }
                }

                AggregatingSymbols.RemoveRange(0, ing);
            }

            // Searching becomes harder (AggregatingSymbols in use).
            for (var i = 0; i < AggregatingSymbols.Count; i++)
            {
                Frequencies.Add(AggregatingSymbols[i], Regex.Matches(source, AggregatingSymbols[i]).Count);
            }

            if (nouse)
            {
                List<string> nouseKeys = new List<string>();

                foreach (var item in Frequencies)
                {
                    if (item.Value == 0)
                        nouseKeys.Add(item.Key);
                }

                foreach (var key in nouseKeys)
                {
                    Frequencies.Remove(key);
                }
            }

            CodeNames = new Dictionary<string, string>();

            int cn = 0;
            foreach (var item in Frequencies)
            {
                CodeNames.Add(item.Key, $"{Convert.ToChar('a' + AggreagtionLen - 1)}{cn++}");
            }

            foreach (var symbol in Frequencies) nodes.Add(new Node {Symbol = symbol.Key, Frequency = symbol.Value});

            while (nodes.Count > 1)
            {
                var orderedNodes = nodes.OrderBy(node => node.Frequency).ToList();

                if (orderedNodes.Count >= 2)
                {
                    // Take first two items
                    var taken = orderedNodes.Take(2).ToList();

                    // Create a parent node by combining the frequencies
                    var parent = new Node
                    {
                        Symbol = "*",
                        Frequency = taken[0].Frequency + taken[1].Frequency,
                        Left = taken[0],
                        Right = taken[1]
                    };

                    nodes.Remove(taken[0]);
                    nodes.Remove(taken[1]);
                    nodes.Add(parent);
                }

                Root = nodes.FirstOrDefault();
            }

            foreach (var item in Frequencies)
            {
                Result.Add(item.Key, Tuple.Create(CodeNames[item.Key], EncodeBits(item.Key),
                    Convert.ToDouble(item.Value) / Convert.ToDouble(source.Length)));
            }
        }

        // EncodeBits WILL NOT ENCODE LAST TAILING SYMBOLS.
        public string EncodeBits(string source)
        {
            var encodedSource = new List<string>();

            for (var i = 0; i <= source.Length - AggreagtionLen; i += AggreagtionLen)
            {
                var encodedSymbol = Root.Traverse(source.Substring(i, AggreagtionLen), new List<string>());
                encodedSource.AddRange(encodedSymbol);
            }
            string ret = "";
            encodedSource.ForEach(x => { ret += x; });
            return ret;
        }
        public string EncodeString(string source)
        {
            return EncodeBits(source);
        }

        // DO NOT DECODE WHEN aggregated IN Build() IS > 1
        public string Decode(string bits)
        {
            if (AggreagtionLen > 2)
                return "";

            var current = Root;
            var decoded = "";

            foreach (char bit in bits)
            {
                if (bit == '1')
                {
                    if (current.Right != null) current = current.Right;
                }
                else
                {
                    if (current.Left != null) current = current.Left;
                }

                if (IsLeaf(current))
                {
                    decoded += current.Symbol;
                    current = Root;
                }
            }

            return decoded;
        }

        public bool IsLeaf(Node node)
        {
            return node.Left == null && node.Right == null;
        }
    }
}