using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Watics.Models
{
    //상속받은 클래스 타입에 따라 수정 필요
    [Serializable]
    public class GameItem
    {
        //아이템 이름
        public string name { get; set; }
        //간단한 아이템 설명
        public string description { get; set; }
        //아이템 타입. 무기, 물약, 음식, 중요한 것, etc.
        public string type { get; set; }
        //아이템의 두번째 타입 설정. 무기면 창이나 활, 물약이면 회복이나 기타 물약 등등
        public string subType { get; set; }
        //attribute applies differently to each item type. For example on a weapon it will be its base damage, or on a health potion how much health it restores
        public int attribute { get; set; }

        //내구도는 빼자
        //durability of a weapon will determine how many uses you can get out of it, for consumables like food and potions this will always be set to 1.
        //public int durability { get; set; }

    }
}
