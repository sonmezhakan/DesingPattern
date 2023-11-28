﻿using CA_FactoryMethod.Abstract;
using CA_FactoryMethod.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_FactoryMethod.Entity
{
    public class MidField : IFootballer
    {
        private string _mevki;
        public MidField()
        {
            _mevki = "Orta Saha";
        }
        public void Calim()
        {
            Messages.Calim(_mevki);
        }

        public void Dripling()
        {
            Messages.Dripling(_mevki);
        }

        public void Orta()
        {
            Messages.Orta(_mevki);
        }

        public void Sut()
        {
            Messages.Sut(_mevki);
        }
    }
}
