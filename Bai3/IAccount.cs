using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;

namespace BankSystemManagement
{
    interface IAccount
    {
        void ShowInfo();
        float PayInto(float Amount);
    }
}