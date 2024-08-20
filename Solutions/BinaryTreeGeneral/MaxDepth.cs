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
        {   // Base case: if the root is null, the tree is empty, so the depth is 0
            if (root == null)
            {
                return 0;
            }
            //Recusively compute depth of each side until base case is reached
            int LeftDepth = MaxDepth(root.left);
            int RightDepth = MaxDepth(root.right);
            return Math.Max(LeftDepth, RightDepth)+1;
        }
    }
}
