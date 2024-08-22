﻿namespace BinaryTreeBFS
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
    public class AverageLevelTests
    {
        public IList<double> AverageOfLevels(TreeNode root)
        {
            var resut = new List<double>();
            var queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            while (queue.Count > 0) 
            {
                int levelItemCount = queue.Count;
                int levelSum = 0;
                for (int i = 0; i < queue.Count; i++) 
                { 
                    var node = queue.Dequeue();
                    levelSum += node.val;
                    if (node.left != null) queue.Enqueue(node.left);
                    if (node.right != null) queue.Enqueue(node.right);
                }
                resut.Add(levelSum/levelItemCount);
            }
            return resut;
        }
    }
}
