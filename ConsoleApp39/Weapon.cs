using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp39
{
   public  enum Weapon
    {
        工业橡胶手套,
        重拳摩托车手套,
        破旧的拳击手套,
        崭新的拳击手套,
        指虎,
        一级改装拳击手套,
        二级改装拳击手套,
        三级改装拳击手套,
        狼爪金属手套,
        破树枝,
        水果刀,
        棒球棒,
        破旧的匕首,
        崭新的匕首,
        尼泊尔弯刀,
        卷刃的太刀,
        锋利的太刀,
        破旧的柴刀,
        柴刀,
        缠布的柴刀,
        消防斧,
        一级改装消防斧,
        二级改装消防斧,
        三级改装消防斧,
        自制钢管铳,
        破旧的六四式,
        破旧的格洛克17,
        破旧的沙鹰,
        破旧的驳壳枪,
        六四式,
        格洛克17,
        驳壳枪,
        沙鹰,
        自制霰弹枪,
        削短霰弹枪,
        MP133霰弹枪,
        M870霰弹枪,
        破旧的花机关,
        破旧的MP5,
        破旧的M3A1,
        UZI,
        MP5,
        破旧五六半自动步枪,
        破旧的中正式步枪,
        五六半自动步枪,
        破旧81式自动步枪,
        八一式自动步枪,
        AK74式自动步枪,
        M16自动步枪
    };
   public class WEAPON
    {
        /// <summary>
        /// 攻击力
        /// </summary>
        public int attack;
        /// <summary>
        /// 需求点数
        /// </summary>
        public int GetCount;
        /// <summary>
        /// 需求力量
        /// </summary>
        public int Getstrength;
        /// <summary>
        /// 攻击距离
        /// </summary>
        public int AttackRange;
        /// <summary>
        /// 武器类型，0=无弹药，1=有弹药
        /// </summary>
        public int WeaponType;
        /// <summary>
        /// 武器单弹匣弹药数量
        /// </summary>
        public int Ammo;
        /// <summary>
        /// 单回单一次数
        /// </summary>
        public int ATTACKS;
        /// <summary>
        /// 单回合复数次数
        /// </summary>
        public int ATTACKSS;
        /// <summary>
        /// 价格
        /// </summary>
        public int Price;
        /// <summary>
        /// 武器描述
        /// </summary>
        public string Wd;
        /// <summary>
        /// 暴击率
        /// </summary>
        public double CriticalStrike;
        /// <summary>
        /// 定义每种武器的基础属性
        /// </summary>
        /// <param name="weapon">武器字段</param>
        public void SetWeapon(string weapon)
        {
            if(Weapon.工业橡胶手套.ToString() == weapon)
            {
                attack = 4;
                GetCount = 2;
                Getstrength = 3;
                AttackRange = 1;
                WeaponType = 0;
                ATTACKS = 1;
                Price = 60;
                CriticalStrike = 0.03;
                
                Wd = "这是你在工地上的工人手上经常看到的橡胶手套，虽然它并不是为打仗而生。不过在打群架时面对赤手空拳的敌人它会让你倍感安全！暴击率3%";




            }
            if (Weapon.重拳摩托车手套.ToString() == weapon)
            {
                attack = 5;
                GetCount = 2;
                Getstrength = 3;
                AttackRange = 1;
                WeaponType = 0;
                ATTACKS = 1;
                CriticalStrike = 0.03;
                Wd = "这是大排量摩托车骑士的最爱!它背面坚硬如石头的硬塑料和整片手掌厚厚的橡胶宣誓了它可以保护你的很好的保护你的手掌！最重要的是它带着非常舒服！防御力+1,暴击率3%";
            }
            if (Weapon.破旧的拳击手套.ToString() == weapon)
            {
                attack = 6;
                GetCount = 2;
                Getstrength = 3;
                AttackRange = 1;
                WeaponType = 0;
                ATTACKS = 1;
                CriticalStrike = 0.03;
                Wd = "这一看就是从垃圾场淘来的破烂货，不过外表看起来很旧很破，但简单的缝缝补补后依旧能看得出它当年在擂台上的威风凛凛。暴击率3%";
            }
            if (Weapon.崭新的拳击手套.ToString() == weapon)
            {
                attack = 8;
                GetCount = 3;
                Getstrength = 3;
                AttackRange = 1;
                WeaponType = 0;
                ATTACKS = 1;
                CriticalStrike = 0.04;
                Wd = "一个崭新的拳击手套，它看起来好像一拳就能把人打趴下！暴击率4%";
            }
            if (Weapon.指虎.ToString() == weapon)
            {
                attack = 10;
                GetCount = 3;
                Getstrength = 4;
                AttackRange = 1;
                WeaponType = 0;
                ATTACKS = 1;
                CriticalStrike = 0.04;
                Wd = "打群架最不能缺少的武器！手指虎！暴击率4%";
            }
            if(Weapon.一级改装拳击手套.ToString() == weapon)
            {
                attack = 13;
                GetCount = 3;
                Getstrength = 4;
                AttackRange = 1;
                WeaponType = 0;
                ATTACKS = 1;
                CriticalStrike = 0.04;
                Wd = "有人将手指虎的打击头磨的尖尖的，它看起来非常危险！暴击率4%";
            }
            if (Weapon.二级改装拳击手套.ToString() == weapon)
            {
                attack = 14;
                GetCount = 3;
                Getstrength = 4;
                AttackRange = 1;
                WeaponType = 0;
                ATTACKS = 1;
                CriticalStrike = 0.04;
                Wd = "有人将手指虎的打击头磨的又长又尖，它看起来非常危险！暴击率4%";
            }
            if (Weapon.三级改装拳击手套.ToString() == weapon)
            {
                attack = 21;
                GetCount = 3;
                Getstrength = 5;
                AttackRange = 2;
                WeaponType = 0;
                ATTACKS = 1;
                CriticalStrike = 0.04;
                Wd = "这手指虎的前面变成了四个开了刃的钢刀，你永远都不想在敌人的手里看到它！暴击率4%";
            }
            if (Weapon.狼爪金属手套.ToString() == weapon)
            {
                attack = 26;
                GetCount = 3;
                Getstrength = 6;
                AttackRange = 2;
                WeaponType = 0;
                ATTACKS = 1;
                CriticalStrike = 0.04;
                Wd = "有人用手指虎金属架和三个匕首的刀刃焊接在一起做的狼爪手套，你真的非常佩服发明这个武器之人的脑洞。暴击率4%";
            }
            if (Weapon.破树枝.ToString() == weapon)
            {
                attack = 4;
                GetCount = 2;
                Getstrength = 4;
                AttackRange = 2;
                WeaponType = 0;
                ATTACKS = 1;
                CriticalStrike = 0.05;
                Wd = "在野外遇到危险时，即便是树上的树枝也能给当敌人当头一棒！暴击率5%";
            }
            if (Weapon.水果刀.ToString() == weapon)
            {
                attack = 4;
                GetCount = 2;
                Getstrength = 4;
                AttackRange = 1;
                WeaponType = 0;
                ATTACKS = 1;
                CriticalStrike = 0.03;
                Wd = "这把刀就是你平时用来切水果的小刀，但它也是一把武器。暴击率3%";

            }
            if (Weapon.棒球棒.ToString() == weapon)
            {
                attack = 6;
                GetCount = 2;
                Getstrength = 4;
                AttackRange = 2;
                WeaponType = 0;
                ATTACKS = 1;
                CriticalStrike = 0.05;
                Wd = "你经常在黑帮和丧尸片里能看到棒球棒对吗？暴击率5%";
            }
            if (Weapon.破旧的匕首.ToString() == weapon)
            {
                attack = 10;
                GetCount = 2;
                Getstrength = 3;
                AttackRange = 1;
                WeaponType = 0;
                ATTACKS = 1;
                CriticalStrike = 0.03;
                Wd = "这东西锈迹斑斑，如果捅到谁的身体里就算捅不死也会因为感染暴毙！暴击率3%";
            }
            if (Weapon.崭新的匕首.ToString() == weapon)
            {
                attack = 11;
                GetCount = 2;
                Getstrength = 3;
                AttackRange = 1;
                WeaponType = 0;
                ATTACKS = 1;
                CriticalStrike = 0.04;
                Wd = "送给一个成年男孩最好的礼物！军用匕首！暴击率4%";
            }

            if (Weapon.尼泊尔弯刀.ToString() == weapon)
            {
                attack = 14;
                GetCount = 2;
                Getstrength = 4;
                AttackRange = 2;
                WeaponType = 0;
                ATTACKS = 1;
                CriticalStrike = 0.04;
                Wd = "这弯刀怎么看怎么都像屠宰场用来宰牛才用的武器,有什么是它砍不断的吗？暴击率4%";
            }
            if (Weapon.卷刃的太刀.ToString() == weapon)
            {
                attack = 19;
                GetCount = 2;
                Getstrength = 4;
                AttackRange = 2;
                WeaponType = 0;
                ATTACKS = 1;
                CriticalStrike = 0.04;
                Wd = "虽然很多地方卷刃了，但当你拔出它时还是被震撼到了，暴击率4%";
            }
            if (Weapon.锋利的太刀.ToString() == weapon)
            {
                attack = 21;
                GetCount = 2;
                Getstrength = 4;
                AttackRange = 2;
                WeaponType = 0;
                ATTACKS = 1;
                CriticalStrike = 0.04;
                Wd = "像镜子一样的反光，又长又锋利的刀刃，轻便又可挥可砍，它就是近战之王。暴击率4%";
            }
            if (Weapon.破旧的柴刀.ToString() == weapon)
            {
                attack = 15;
                GetCount = 2;
                Getstrength = 4;
                AttackRange = 2;
                WeaponType = 0;
                ATTACKS = 1;
                CriticalStrike = 0.04;
                Wd = "虽然平时用来砍木头，但骨头比木头脆多了！暴击率4%";
            }
            if (Weapon.柴刀.ToString() == weapon)
            {
                attack = 17;
                GetCount = 2;
                Getstrength = 4;
                AttackRange = 2;
                WeaponType = 0;
                ATTACKS = 1;
                CriticalStrike = 0.04;
                Wd = "一把崭新的柴刀！暴击率4%";
            }
            if (Weapon.缠布的柴刀.ToString() == weapon)
            {
                attack = 19;
                GetCount = 2;
                Getstrength = 4;
                AttackRange = 2;
                WeaponType = 0;
                ATTACKS = 1;
                CriticalStrike = 0.04;
                Wd = "可以跟敌人进行持久战的武器！你再也不会因为虎口疼影响发挥了！暴击率4%";
            }
            if (Weapon.消防斧.ToString() == weapon)
            {
                attack = 25;
                GetCount = 4;
                Getstrength = 6;
                AttackRange = 2;
                WeaponType = 0;
                ATTACKS = 1;
                CriticalStrike = 0.05;
                Wd = "这东西可是能劈一切的武器，拿在手上野猪见了都害怕！暴击率5%";
            }
            if (Weapon.一级改装消防斧.ToString() == weapon)
            {
                attack = 27;
                GetCount = 4;
                Getstrength = 7;
                AttackRange = 2;
                WeaponType = 0;
                ATTACKS = 1;
                CriticalStrike = 0.05;
                Wd = "这把消防斧被加固过，更加耐久了！也更沉了。暴击率5%";
            }
            if (Weapon.二级改装消防斧.ToString() == weapon)
            {
                attack = 29;
                GetCount = 4;
                Getstrength = 7;
                AttackRange = 2;
                WeaponType = 0;
                ATTACKS = 1;
                CriticalStrike = 0.05;
                Wd = "这把消防斧被加固过，更加耐久了！也更沉了。暴击率5%";
            }
            if (Weapon.三级改装消防斧.ToString() == weapon)
            {
                attack = 31;
                GetCount = 5;
                Getstrength = 6;
                AttackRange = 2;
                WeaponType = 0;
                ATTACKS = 1;
                CriticalStrike = 0.1;
                Wd = "这把武器好像用了昂贵的聚合物，使得它比之前的更轻更结实了。暴击率10%";
            }
            if (Weapon.自制钢管铳.ToString() == weapon)
            {
                attack = 11;
                GetCount = 5;
                Getstrength = 4;
                AttackRange = 5;
                WeaponType = 1;
                Ammo = 1;
                ATTACKS = 1;
                CriticalStrike = 0.03;
                Wd = "你看到一个钢管后面被焊死，只在上面留了一个小口，小口外面伸出一根长长引火线，钢管的旁边还摆着很多钢珠。你很纳闷它是怎么发射的？暴击率3%";
            }
            if (Weapon.破旧的六四式.ToString() == weapon)
            {
                attack = 14;
                GetCount = 3;
                Getstrength = 4;
                AttackRange = 5;
                WeaponType = 1;
                Ammo = 7;
                ATTACKS = 1;
                CriticalStrike = 0.04;
                Wd = "有点生锈的大炮匝，以前就经常卡壳，可想现在的状况。暴击率4%";
            }
            if (Weapon.六四式.ToString() == weapon)
            {
                attack = 15;
                GetCount = 3;
                Getstrength = 4;
                AttackRange = 6;
                Ammo = 7;
                ATTACKS = 1;
                CriticalStrike = 0.04;
                Wd = "以前警察装备的警用手枪，虽然它的性能让人诟病，但威力还可以。暴击率4%";
            }
            if (Weapon.破旧的格洛克17.ToString() == weapon)
            {
                attack = 14;
                GetCount = 2;
                Getstrength = 4;
                AttackRange = 6;
                Ammo = 17;
                ATTACKS = 1;
                CriticalStrike = 0.04;
                Wd = "这枪到底经历了多少场战斗了，它一共有多少任主人？暴击率4%";
            }
            if (Weapon.格洛克17.ToString() == weapon)
            {
                attack = 16;
                GetCount = 2;
                Getstrength = 4;
                AttackRange = 7;
                Ammo = 17;
                ATTACKS = 1;
                CriticalStrike = 0.04;
                Wd = "这枪到底经历了多少场战斗了，它一共有多少任主人？暴击率4%";
            }
            if (Weapon.破旧的驳壳枪.ToString() == weapon)
            {
                attack = 15;
                GetCount = 3;
                Getstrength = 5;
                AttackRange = 7;
                Ammo = 10;
                ATTACKS = 1;
                ATTACKSS = 4;
                CriticalStrike = 0.04;
                Wd = "这枪到底经历了多少场战斗了，它一共有多少任主人？暴击率4%";
            }
            if (Weapon.驳壳枪.ToString() == weapon)
            {
                attack = 17;
                GetCount = 3;
                Getstrength = 5;
                AttackRange = 8;
                Ammo = 15;
                ATTACKS = 1;
                ATTACKSS = 4;
                CriticalStrike = 0.04;
                Wd = "这是一把上个时代的驳壳枪，但它火力强大。暴击率4%";
            }
            if (Weapon.破旧的沙鹰.ToString() == weapon)
            {
                attack = 17;
                GetCount = 3;
                Getstrength = 6;
                AttackRange = 7;
                Ammo = 6;
                ATTACKS = 1;
                CriticalStrike = 0.06;
                Wd = "威力恐怖的武器，一枪能打死一头牛，虽然他已经快坏了。暴击率6%";
            }
            if (Weapon.沙鹰.ToString() == weapon)
            {
                attack = 22;
                GetCount = 4;
                Getstrength = 6;
                AttackRange = 8;
                Ammo = 7;
                ATTACKS = 1;
                CriticalStrike = 0.06;
                Wd = "一把崭新的猎牛武器。但后坐力也大的出奇！暴击率6%";
            }
            if (Weapon.自制霰弹枪.ToString() == weapon)
            {
                attack = 16;
                GetCount = 4;
                Getstrength = 5;
                AttackRange = 4;
                Ammo = 1;
                ATTACKS = 1;
                CriticalStrike = 0.06;
                Wd = "轰！开火吧！恐惧吧！暴击率5%";
            }
            if (Weapon.削短霰弹枪.ToString() == weapon)
            {
                attack = 25;
                GetCount = 4;
                Getstrength = 5;
                AttackRange = 3;
                Ammo = 2;
                ATTACKS = 1;
                ATTACKSS = 2;
                CriticalStrike = 0.1;
                Wd = "这是一把双联霰弹枪的削短款，虽然它的射击距离变得更近，但它的威力变得更大了。暴击率10%";
            }
            if (Weapon.MP133霰弹枪.ToString() == weapon)
            {
                attack = 20;
                GetCount = 4;
                Getstrength = 6;
                AttackRange = 6;
                Ammo = 5;
                ATTACKS = 1;
                CriticalStrike = 0.06;
                Wd = "这是一把猎户经常打猎用的猎枪，但它装的是12G。暴击率6%";
            }
            if (Weapon.M870霰弹枪.ToString() == weapon)
            {
                attack = 23;
                GetCount = 4;
                Getstrength = 5;
                AttackRange = 6;
                Ammo = 7;
                ATTACKS = 1;
                CriticalStrike = 0.06;
                Wd = "一把只有镇暴时才会出现的暴力大杀器！暴击率6%";
            }
            if (Weapon.破旧的花机关.ToString() == weapon)
            {
                attack = 8;
                GetCount = 3;
                Getstrength = 5;
                AttackRange = 8;
                Ammo = 20;
                ATTACKSS = 5;
                CriticalStrike = 0.04;
                Wd = "突突突！每一颗子弹都消灭一个敌人~暴击率4%";
            }
            if (Weapon.破旧的MP5.ToString() == weapon)
            {
                attack = 10;
                GetCount = 3;
                Getstrength = 5;
                AttackRange = 10;
                Ammo = 25;
                ATTACKSS = 5;
                CriticalStrike = 0.04;
                Wd = "你感觉它全身都松松垮垮的，但你依旧认识它就是大名鼎鼎的MP5。暴击率4%";
            }
            if (Weapon.破旧的M3A1.ToString() == weapon)
            {
                attack = 10;
                GetCount = 3;
                Getstrength = 5;
                AttackRange = 8;
                Ammo = 20;
                ATTACKSS = 5;
                CriticalStrike = 0.04;
                Wd = "人们喜欢称呼它为注油枪！但它已经浑身锈迹斑斑了，你认为它不可能正常使用。暴击率4%";
            }
            if (Weapon.UZI.ToString() == weapon)
            {
                attack = 8;
                GetCount = 3;
                Getstrength = 5;
                AttackRange = 6;
                Ammo = 31;
                ATTACKSS = 6;
                CriticalStrike = 0.04;
                Wd = "你把油纸打开，发现了这把小巧却火力强大的宝贝！他永远都是黑帮的最爱！暴击率4%";
            }
            if (Weapon.MP5.ToString() == weapon)
            {
                attack = 12;
                GetCount = 3;
                Getstrength = 6;
                AttackRange = 12;
                Ammo = 30;
                ATTACKSS = 5;
                CriticalStrike = 0.04;
                Wd = "一把标准的反恐武器！它射速惊人，最重要的是指哪打哪！暴击率4%";
            }
            if (Weapon.破旧五六半自动步枪.ToString() == weapon)
            {
                attack = 24;
                GetCount = 4;
                Getstrength = 6;
                AttackRange = 19;
                Ammo = 10;
                ATTACKS = 1;
                CriticalStrike = 0.06;
                Wd = "曾经的解放军手中的卫国利器，虽然外表陈旧，但你觉得它象征着一种精神！一种永不言败的精神。暴击率6%";
            }
            if (Weapon.五六半自动步枪.ToString() == weapon)
            {
                attack = 30;
                GetCount = 5;
                Getstrength = 6;
                AttackRange = 20;
                Ammo = 10;
                ATTACKS = 1;
                CriticalStrike = 0.06;
                Wd = "曾经的解放军手中的卫国利器，你觉得它象征着一种精神！一种永不言败的精神。暴击率6%";
            }
            if (Weapon.破旧的中正式步枪.ToString() == weapon)
            {
                attack = 30;
                GetCount = 6;
                Getstrength = 6;
                AttackRange = 24;
                Ammo = 5;
                ATTACKS = 1;
                CriticalStrike = 0.06;
                Wd = "没有一发子弹解决不了的敌人，如果不行那就两发！暴击率6%";
            }
            if (Weapon.破旧81式自动步枪.ToString() == weapon)
            {
                attack = 15;
                GetCount = 6;
                Getstrength = 7;
                AttackRange = 18;
                Ammo = 20;
                ATTACKS = 1;
                ATTACKSS = 7;
                CriticalStrike = 0.06;
                Wd = "没有一发子弹解决不了的敌人，如果不行那就两发！暴击率6%";
            }
            if (Weapon.八一式自动步枪.ToString() == weapon)
            {
                attack = 17;
                GetCount = 6;
                Getstrength = 7;
                AttackRange = 20;
                Ammo = 30;
                ATTACKS = 1;
                ATTACKSS = 7;
                CriticalStrike = 0.1;
                Wd = "它是由伟大的祖国研发的大威力步枪，每扳动一次扳机，都会有人倒下！暴击率10%";
            }
            if (Weapon.AK74式自动步枪.ToString() == weapon)
            {
                attack = 18;
                GetCount = 6;
                Getstrength = 7;
                AttackRange = 20;
                Ammo = 30;
                ATTACKS = 1;
                ATTACKSS = 7;
                CriticalStrike = 0.1;
                Wd = "苏制武器，是AK47的改进版！暴击率10%";
            }
            if (Weapon.M16自动步枪.ToString() == weapon)
            {
                attack = 16;
                GetCount = 5;
                Getstrength = 6;
                AttackRange = 20;
                Ammo = 30;
                ATTACKS = 1;
                ATTACKSS = 7;
                CriticalStrike = 0.09;
                Wd = "带上它，你就是越战精英！暴击率9%";
            }





        }

    }
}
