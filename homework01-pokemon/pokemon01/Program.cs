using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PokemonManagementLibrary;

namespace pokemon01
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            pokemon pokemon = new pokemon()
            {
                name = "妙蛙種子",
                hp = "60",
                gender = "男",
                weight = "5.94kg",
                attribute = "草/毒",
                height = "0.67m",
                star = "271484",
                candy = "27",
                powerup = "3000星星+3糖果",
                evolve = "25糖果",
                skill1 = "藤鞭",
                skill1dmg = "7",
                skill2 = "汙泥炸彈",
                skill2dmg = "80",
                location = "台灣，新北市三重區",
                date = "9/14/2016",
            };
            Console.WriteLine("名稱:{0}, 血量:{1}, 性別:{2}, 體重:{3}, 屬性:{4}, 身高:{5}," +
                              "星星沙子:{6}, 妙蛙種子的糖果:{7}, 強化:{8}, 進化:{9}, 技能1:{10}, " +
                              "技能1攻擊力:{11}, 技能2:{12}, 技能2攻擊力:{13}, 捕捉地點:{14}, 捕捉日期:{15}"
                , pokemon.name
                , pokemon.hp
                , pokemon.gender
                , pokemon.weight
                , pokemon.attribute
                , pokemon.height
                , pokemon.star
                , pokemon.candy
                , pokemon.powerup
                , pokemon.evolve
                , pokemon.skill1
                , pokemon.skill1dmg
                , pokemon.skill2
                , pokemon.skill2dmg
                , pokemon.location
                , pokemon.date
                );
        }
    }
}