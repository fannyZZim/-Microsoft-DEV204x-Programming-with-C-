﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mod6
{
    class Person
    {
        private string _firstName;
        private string _lastName;
        private string _sex;

        #region Properties
        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }
        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }
        public string Sex
        {
            get { return _sex; }
            set { _sex = value; }
        }
        #endregion



    }
}
