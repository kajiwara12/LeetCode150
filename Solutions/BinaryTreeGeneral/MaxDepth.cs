namespace BinaryTreeGeneral
{
     public class TreeNode
    {
     public int val;
      public TreeNode left;
      public TreeNode right;
      public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
           this.left = left;
            this.right = right;
                 }
  }


    public class MaxDepthh
    {
        public int MaxDepth(TreeNode root)
        {   // Way to exit the recursion if the root is null, the tree is empty, so the depth is 0
            if (root == null)
            {
                return 0;
            }
            //Recusion
            int LeftDepth = MaxDepth(root.left);
            int RightDepth = MaxDepth(root.right);
            return Math.Max(LeftDepth, RightDepth)+1;
        }
    }
}
