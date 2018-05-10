using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.Interface.Interfaces;

namespace BLL.ServiceImplementation
{
    public class AccountGenerateIdNumber : IAccountGenerateIdNumber
    {
        /// <summary>
        /// Generate unique 32 length Id number
        /// </summary>
        /// <returns>unique Id number</returns>
        public string GenerateId()
        {
            return Guid.NewGuid().ToString("N");
        }
    }
}
