namespace BinarySearchTree
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
    public class MinAbsDiff
    {
        private int minDifference = int.MaxValue;
        private TreeNode prevNode = null;

        public int GetMinimumDifference(TreeNode root)
        {
            if (root == null) return 0;
            Traversal(root);
            return minDifference;
        }
        public void Traversal(TreeNode node)
        {
            if (node == null) return;

            Traversal(node.left);
            if (prevNode != null)
            {
                int value = Math.Abs(node.val - prevNode.val);
                if (value < minDifference) minDifference = value;
            }
            prevNode = node;
            Traversal(node.right);

        }
    }
}
