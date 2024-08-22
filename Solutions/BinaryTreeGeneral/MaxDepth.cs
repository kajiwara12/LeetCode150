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


    public class MergeSort
    {
        public static void Sort(int[] array)
        {
            if (array == null || array.Length <= 1)
                return;

            int[] tempArray = new int[array.Length];
            MergeSortRecursive(array, tempArray, 0, array.Length - 1);
        }

        private static void MergeSortRecursive(int[] array, int[] tempArray, int left, int right)
        {
            if (left >= right)
                return;

            int middle = left + (right - left) / 2;
            MergeSortRecursive(array, tempArray, left, middle);
            MergeSortRecursive(array, tempArray, middle + 1, right);
            Merge(array, tempArray, left, middle, right);
        }

        private static void Merge(int[] array, int[] tempArray, int left, int middle, int right)
        {
            int i = left, j = middle + 1, k = left;

            // Copy both halves into the temporary array
            while (i <= middle && j <= right)
            {
                if (array[i] <= array[j])
                {
                    tempArray[k++] = array[i++];
                }
                else
                {
                    tempArray[k++] = array[j++];
                }
            }

            // Copy the remaining elements of the left half, if any
            while (i <= middle)
            {
                tempArray[k++] = array[i++];
            }

            // Copy the remaining elements of the right half, if any
            while (j <= right)
            {
                tempArray[k++] = array[j++];
            }

            // Copy the sorted elements back into the original array
            for (i = left; i <= right; i++)
            {
                array[i] = tempArray[i];
            }
        }
    }

}
