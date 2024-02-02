using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp39
{
    class SKILL
    {
        public List<string> SKILL_N { get; set; }
        public void setSkill()
        {
            SKILL_N.Add("近身枪械");
            SKILL_N.Add("远程枪械");
            SKILL_N.Add("近身武器");
            SKILL_N.Add("近身格斗");
            SKILL_N.Add("自动枪械");
            SKILL_N.Add("开锁");
            
        }
        public void GetSkill_近身枪械(string jineng)
        {
            if (jineng == "近身枪械")
            {
                
            }
        }
    }
}
