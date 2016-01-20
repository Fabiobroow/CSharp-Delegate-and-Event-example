using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlausurVorbereitung_Delegate_Events
{
    public delegate void UserInfoDelegate();


    class UserCheckEventClass
    {
        public event UserInfoDelegate UserInfoEvent;

        public void ShowUser()
        {

            UserInfoEvent();
        }
    }
}
