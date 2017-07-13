using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PokemonLibrary;

namespace Pokemon
{
    internal class Pokemon
    {
        private static void Main(string[] args)
        {
            PokemonLibrary.Pokemon_all aPokemonLibrary = new PokemonLibrary.Pokemon_all()
            {
                name = "種子",
                gender = true,
                hp = 60,
                hp_total = 60,
                Weight = 5.94f,
                property = "草/毒",
                height = 0.67f,
                stardust = 2467813,
                candy = 12,
                skill1 = "藤鞭",
                skill1_power = 7,
                skill2 = "炸彈",
                skill2_power = 80
            };
            Console.WriteLine(
                "名稱:{0}," +
                "性別:{1}," +
                "血量:{2}," +
                "總血量:{3}" +
                "體重:{4}," +
                "屬性:{5}," +
                "身高:{6}," +
                "星塵:{7}," +
                "糖果:{8}," +
                "技能1:{9}," +
                "技能1 能量:{10}," +
                "技能2:{11}," +
                "技能2 能量{12}:"
                , aPokemonLibrary.name
                , aPokemonLibrary.gender
                , aPokemonLibrary.hp
                , aPokemonLibrary.hp_total
                , aPokemonLibrary.Weight
                , aPokemonLibrary.property
                , aPokemonLibrary.height
                , aPokemonLibrary.stardust
                , aPokemonLibrary.candy
                , aPokemonLibrary.skill1
                , aPokemonLibrary.skill1_power
                , aPokemonLibrary.skill2
                , aPokemonLibrary.skill2_power
                );
        }
    }
}