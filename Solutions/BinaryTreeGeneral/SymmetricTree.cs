using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTreeGeneral
{
    public class SymmetricTree
    {
        public bool IsSymmetric(TreeNode root)
        {   //base case
            if(root== null) return false;
            
            
            return helper(root.left,root.right);

            //check left and right to see if they are a mirror
            //left.left == right.right && left.right == right.left
            //check values as well

            bool helper(TreeNode left,TreeNode right) 
            {
                if (left == null && right == null) return true;
                if (left == null || right == null) return false;
                return helper(left.left,right.right) && helper(left.right,right.left)&&(left.val==right.val);

            }
        }
    }
}
