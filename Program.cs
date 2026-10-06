using System;

namespace OverridingMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== DEMO OVERRIDING & OVERLOADING (GAME SKILLS) ===\n");

            PhysicalSkill slash = new PhysicalSkill(0.3f, "slash", 50f, 15f);
            slash.DisplaySkillInfo();
           
            Console.WriteLine("\n--- Menguji Overloading Method ---");

            // 3. Heal Skill
            float dmg1 = slash.CalculateDamage();
            Console.WriteLine("Damage (tanpa parameter): " + dmg1);

            float dmg2 = slash.CalculateDamage(2.0f);
            Console.WriteLine("Damage (multiplier 2.0):" + dmg2);

            float dmg3= slash.CalculateDamage(1.5f,20f);
            Console.WriteLine("Damage (multiplier 1.5, defense 20): " + dmg3);

            float dmg4 = slash.CalculateDamage("Piercing");
            Console.WriteLine("Damage (tipe piercing): " + dmg4);

            float dmg5 =slash.CalculateDamage(true);
            Console.WriteLine("Damage (backstab true): " +dmg5);

            Console.ReadKey();

        }
    }
}