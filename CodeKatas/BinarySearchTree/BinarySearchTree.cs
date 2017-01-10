using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeKatas.BinarySearchTree
{
    public class BinarySearchTree
    {
        public static bool Contains(Node root, int value)
        {
            // value of each node is larger or equal to the values in all the nodes in that node's left subtree
            //and is smaller than the values in all the nodes in that node's right subtree.




        }



        public static bool IsValidBST(Node root)
        {
            return IsValid(root, int.MinValue, int.MaxValue);
        }

        private static bool IsValid(Node node, int minValue, int maxValue)
        {
            if (node == null)
                return true;

            if (node.Value > minValue && node.Value <= maxValue)
                return IsValid(node.Left, minValue, node.Value) && IsValid(node.Right, node.Value, maxValue);

            return false;
        }

    }
}
