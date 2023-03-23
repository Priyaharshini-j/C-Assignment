using System;

namespace HerovsVillan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Hero_BulletNo = 0;
            int Villan_BulletNo = 0;
            int hero_shoot = 1, villan_shoot = 1;

            // Get the number of bullet the Hero has
            Console.WriteLine("Enter the number of Bullet the Hero has");
            Hero_BulletNo=Convert.ToInt32(Console.ReadLine());

            // Get the number of bullet the Hero has
            Console.WriteLine("Enter the number of Bullet the Villan has");
            Villan_BulletNo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Let us consider Hero and Villian Shoots alternatively");

            while (hero_shoot <= Hero_BulletNo && (villan_shoot+2) <= Villan_BulletNo)
            {

                Console.WriteLine("The Hero shot the " + hero_shoot + " Bullet");

                Console.WriteLine("The Villan shot the " + villan_shoot+ " Bullet "+ (villan_shoot+1)+ " Bullet "+ (villan_shoot + 2)+ " Bullet ");
                hero_shoot++;
                villan_shoot += 3;
            }

            if(hero_shoot ==  villan_shoot || Hero_BulletNo==Villan_BulletNo)
            {
                Console.WriteLine("Draw");
            }
            else if (Hero_BulletNo > Villan_BulletNo )
            {
                Console.WriteLine("Hero Wins");
            }
            else
            {
                Console.WriteLine("Villan Wins");

            }
        }

    }
}
