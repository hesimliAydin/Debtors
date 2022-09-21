using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Debtors
{
    public class Debtor
    {
        public string? FullName { get; set; }
        public DateTime BirthDay { get; set; }
        public string? Phone { get; set; }
        public string? Email { get; set; }
        public string? Address { get; set; }
        public int Debt { get; set; }

        public Debtor(string fullname, DateTime birthDay, string phone, string email, string address, int debt)
        {
            FullName = fullname;
            BirthDay = birthDay;
            Phone = phone;
            Email = email;
            Address = address;
            Debt = debt;
        }

        public override string ToString()
        {
            return @$"
FullName: {FullName}
BirthDay: {BirthDay.ToShortDateString()}
Phone: {Phone}
Email: {Email}
Address: {Address}
Debt: {Debt}";
        }
    }
}
