using System;

namespace OverridingMethod
{
    public class MagicSkill : Skill
    {
        private string? elementType;

        public MagicSkill()
        {
            elementType = "Normal";
            Console.WriteLine("----> Konstruktor default MagicSkill");

        }

        public MagicSkill(string elementType, string name, float power, float cost)
            : base(name, power, cost)
        {
            Console.WriteLine("----> Konstruktor berparameter MagicSkill <---- ");
            this.elementType = elementType;

            
        }

        public override float CalculateDamage()
        {
            Console.WriteLine("[MagicSkill.Calculatedamage] Menghitung damage sihir dengan elemen...");
            float damage = basePower;
            if (elementType == "Fire")
            {

                damage *= 1.5f;
                Console.WriteLine("[MagicSkill] Bonus elemen Fire! Damage x1.5");

            }
            else if (elementType == "Ice")
            {
                damage *= 1.2f;
                Console.WriteLine("[MagicSkill] Bonus elemen Ice! Damage x1.2");
            }
            return damage;
        
        }

        public override void DisplaySkillInfo()
        {
            base.DisplaySkillInfo();
            Console.WriteLine("ELEMENT TYPE : " + elementType);
            Console.WriteLine("========================");

        }
    }
}