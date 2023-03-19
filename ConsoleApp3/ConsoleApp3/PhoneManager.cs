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
            if ( pNum.Length== 10  ) {

               if( !checkFirst3(pNum)) {
                    return false;
                }
              
            }
            if (checkCentralOffice(pNum)) {
                result = true;
            }


            return result;
        }

        public  bool checkCentralOffice(string pNum) {
            bool result = true;
            string cOff = null;
            if( pNum.Length == 10  ) {
                cOff = pNum.Substring(3, 3);
               
            } else {
                cOff = pNum.Substring(0, 2);
            }
            if (cOff[0] == '1') return false;
            if (cOff[1] == '9') return false;

            return result;
        }

        public Boolean checkFirst3( String phoneNumber ) {
            char fCh = phoneNumber[0];
            if ( fCh >= '2' && fCh <= '9'  ) {
                return true;
            } else {
                return false;
            }

          

        }
    }
       
}
