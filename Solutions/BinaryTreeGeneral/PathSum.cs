using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTreeGeneral
{
    public class PathSum
    {
        public bool HasPathSum(TreeNode root, int targetSum)
        {
            if (root == null) return false;
            if (root.left == null && root.right == null)
            {
                return root.val == targetSum;
            }
            else { targetSum -= root.val; }
            return HasPathSum(root.left, targetSum) || HasPathSum(root.right,targetSum);
        }
    }
}
