using System.Collections.Generic;

namespace HuffmanCode
{
    public partial class HuffmanTree
    {
        public class Node
        {
            public string Symbol { get; set; }
            public int Frequency { get; set; }
            public Node Right { get; set; }
            public Node Left { get; set; }

            public List<string> Traverse(string symbol, List<string> data)
            {
                // Leaf
                if (Right == null && Left == null)
                {
                    if (symbol.Equals(Symbol))
                        return data;
                    return null;
                }

                List<string> left = null;
                List<string> right = null;

                if (Left != null)
                {
                    var leftPath = new List<string>();
                    leftPath.AddRange(data);
                    leftPath.Add("0");

                    left = Left.Traverse(symbol, leftPath);
                }

                if (Right != null)
                {
                    var rightPath = new List<string>();
                    rightPath.AddRange(data);
                    rightPath.Add("1");
                    right = Right.Traverse(symbol, rightPath);
                }

                if (left != null)
                    return left;
                return right;
            }
        }
    }
}