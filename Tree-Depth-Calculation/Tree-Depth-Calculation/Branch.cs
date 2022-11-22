using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tree_Depth_Calculation
{
    internal class Branch
    {
        List<Branch> branches;

        public Branch()
        {
            branches = new List<Branch>();
        }
        public void Add(Branch br)
        {
            this.branches.Add(br);
        }

        public int GetDepth()
        {
            return GetTreeDepth(this, 1);
        }

        public int GetTreeDepth(Branch br, int curr_depth)
        {
            int res = curr_depth;
            foreach (Branch branch in br.branches)
            {
                res = Math.Max(res, GetTreeDepth(branch, curr_depth + 1));
            }
            return res;
        }
    }
}
