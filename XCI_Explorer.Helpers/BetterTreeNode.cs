using System.Windows.Forms;

namespace XCI_Explorer.Helpers
{
	public class BetterTreeNode : TreeNode
	{
		public long Offset;

		public long Size;

		public BetterTreeNode(string t)
		{
			base.Text = t;
		}
	}
}
