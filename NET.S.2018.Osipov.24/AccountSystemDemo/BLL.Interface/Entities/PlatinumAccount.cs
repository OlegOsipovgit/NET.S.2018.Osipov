using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interface.Entities
{
    public class PlatinumAccount : Account
    {
        public PlatinumAccount(string id, string firstName, string lastName, decimal amount, int points, string email)
        : base(id, firstName, lastName, amount, points, email)
        {
            BonusValue = 10;
        }

        public override string ToString() => "PlarimunAccount" + base.ToString();
        public override int CalculatePointsAdd(int bonusValue) => 30 * bonusValue + 20;
        public override int CalculatePointsWithdraw(int bonusValue) => 30 * bonusValue + 20;
        protected override bool IsValidBalance(decimal value)
            => value >= -3000;
    }
}
