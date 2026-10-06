using System;

namespace OverridingMethod
{
    public class PhysicalSkill : Skill
    {
        private float critRate;

        public PhysicalSkill()
        {
            critRate = 0.1f; 
            Console.WriteLine("----. Konstruktor default PhysicalSkill <----");
        }

        public PhysicalSkill(float critRate, string name, float power,  float cost)
           : base(name, power, cost)
        {
            Console.WriteLine("----> Konstruktor berparameter PhysicalSkill <----");
            this.critRate = critRate;
        }

        public override float  CalculateDamage()
        {
            Console.WriteLine("[PhysicalSkill.CalculateDAmage] Menghitung damage fisik dengan crittical hit...");
            return basePower * (1 + critRate);
        }

        public float CalculateDamage(bool isBackstab)
        {
            Console.WriteLine($"[Physicalskill.CalculateDamage] Menghitung damage fisik dengan backstab: {isBackstab}");
            float damage = basePower * (1 + critRate);
            if (isBackstab)
                  damage *= 1.5f;
            return damage;

        }

        public override void DisplaySkillInfo()
        {
            base.DisplaySkillInfo();
            Console.WriteLine();
            Console.WriteLine("=======================");
        }
    }
}