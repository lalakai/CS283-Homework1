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
                skill1 = "藤鞭",
                skill2 = "汙泥炸彈",
            };
            Console.WriteLine("名稱:{0}, 血量:{1}, 性別:{2}, 體重:{3}, 屬性:{4}, 身高:{5}," +
                "技能1:{6}, 技能2:{7}"
                , pokemon.name
                , pokemon.hp
                , pokemon.gender
                , pokemon.weight
                , pokemon.attribute
                , pokemon.height
                , pokemon.skill1
                , pokemon.skill2
                );
        }
    }
}