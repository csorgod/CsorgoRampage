using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsorgoRampage.Enemies
{
    interface IEnemy
    {
        string Name { get; set; }
        double HealthPoints { get; set; }
        double ContactDamage { get; set; }
        double HitDamage { get; set; }

        void TakeDamage(double LossPoints);
        void DoDamage();
    }
}
