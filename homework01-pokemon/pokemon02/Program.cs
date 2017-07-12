using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PokemonManagementLibrary;

namespace pokemon02
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            pokemon pokemon = new pokemon();
            Console.Write("請輸入姓名:");
            pokemon.name = Console.ReadLine();
            Console.Write("請輸入血量:");
            pokemon.hp = Console.ReadLine();
            Console.Write("請輸入性別:");
            pokemon.gender = Console.ReadLine();
            Console.Write("請輸入體重:");
            pokemon.weight = Console.ReadLine();
            Console.Write("請輸入屬性:");
            pokemon.attribute = Console.ReadLine();
            Console.Write("請輸入身高:");
            pokemon.height = Console.ReadLine();
            Console.Write("請輸入技能1:");
            pokemon.skill1 = Console.ReadLine();
            Console.Write("請輸入技能2:");
            pokemon.skill2 = Console.ReadLine();

            Console.WriteLine(
                "姓名:{0}, 血量:{1}, 性別:{2}, 體重:{3}, 屬性:{4}, 身高:{5}, " +
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