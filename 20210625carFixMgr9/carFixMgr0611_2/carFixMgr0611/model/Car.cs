﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carFixMgr0611.model
{
    class Car
    {
        private string model;
        private string number;
        private string cc;
        private string year;
        //DB 설계 : 개념적 설계 논리적 설계 물리적 설계
        public Car(string model, string number, string cc, string year)
        {
            this.model = model;
            this.number = number;
            this.cc = cc;
            this.year = year;
        }

        public string Model { get => model; set => model = value; }
        public string Number { get => number; set => number = value; }
        public string Cc { get => cc; set => cc = value; }
        public string Year { get => year; set => year = value; }
    }
}