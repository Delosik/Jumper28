using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jumper_SviridovKE_PR_20._106.Model
{
    class Connect
    {
        private static JumperSviridovEntities1 jumpcon = new JumperSviridovEntities1();

        public static JumperSviridovEntities1 GetContext()
        {
            if (jumpcon == null)
            {
                jumpcon = new JumperSviridovEntities1();
            } 
            return jumpcon;
                
        }
    }
}
