using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interface.Entities
{
    public class GoldAccount : Account
    {
        public GoldAccount(string id, string firstName, string lastName, decimal amount, int points, string email)
        : base(id, firstName, lastName, amount, points, email)
        {
            BonusValue = 5;
        }

        public override string ToString() => "GoldAccount" + base.ToString();
        public override int CalculatePointsAdd(int bonusValue) => 20 * bonusValue + 5;
        public override int CalculatePointsWithdraw(int bonusValue) => 20 * bonusValue + 10;
        protected override bool IsValidBalance(decimal value)
            => value >= -2000;
    }
}
