using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3 {
    public class PhoneManager {
        String phoneNumber;

        public PhoneManager(string phoneNumber) {
            this.phoneNumber = phoneNumber;
        }
        public Boolean IsPhone() {
            Boolean result = false;
            string pNum = this.phoneNumber.Replace("-", "");
            if (pNum.All(char.IsDigit)) {
                if (pNum.Length == 7 || pNum.Length == 10) {
                    result = true;
                }
                //return true;
            }


            return result;
        }
    }
       
}
