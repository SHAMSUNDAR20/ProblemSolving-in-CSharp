public class Solution {
    public IList<TreeNode> GenerateTrees(int n) {
        if (n == 0) {
            return new List<TreeNode>();
        }
        return GenerateTrees(1, n);
    }

    private IList<TreeNode> GenerateTrees(int start, int end) {
        List<TreeNode> all_trees = new List<TreeNode>();
        if (start > end) {
            all_trees.Add(null);
            return all_trees;
        }

        for (int i = start; i <= end; i++) {
            IList<TreeNode> left_trees = GenerateTrees(start, i - 1);
            IList<TreeNode> right_trees = GenerateTrees(i + 1, end);

            foreach (TreeNode l in left_trees) {
                foreach (TreeNode r in right_trees) {
                    TreeNode current_tree = new TreeNode(i);
                    current_tree.left = l;
                    current_tree.right = r;
                    all_trees.Add(current_tree);
                }
            }
        }
        return all_trees;
    }
}
