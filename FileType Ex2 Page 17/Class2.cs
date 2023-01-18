using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace FileType_Ex2_Page_17
{
    internal class Family
    {
        private string name;
        private int adults;
        private int teenagers;
        private int child;
        private double income;
        //ctors 
        public Family()
        {
            this.name = "";
            this.adults = 0;
            this.teenagers = 0;
            this.child = 0;
            this.income = 0;
        }
        public Family(string name, int adults, int teenagers, int child, double income)
        {
            this.name = name;
            this.adults = adults;
            this.teenagers = teenagers;
            this.child = child;
            this.income = income;
        }
        //setters
        public void SetAdults(int adults)
        {
            this.adults = adults;
        }
        public void SetTeenagers(int teenagers)
        {
            this.teenagers = teenagers;
        }
        public void SetChild(int child)
        {
            this.child = child;
        }
        public void SetIncome(double income)
        {
            this.income = income;
        }
        //getters
        public string GetName()
        {
            return this.name;
        }
        public int GetAdult()
        {
            return this.adults;
        }
        public int GetTeenagers()
        {
            return this.teenagers;
        }
        public int GetChild()
        {
            return this.child;
        }
        public double GetIncome()
        {
            return this.income;
        }
        public double waterpoints()
        {
            double points = 0;
            for (int i = adults; i > 0; i--)
            {
                points++;
            }
            for (int i = teenagers; i > 0; i--)
            {
                points += 0.7;
            }
            for (int i = child; i > 0; i--)
            {
                points+=0.5;
            }
            return points;
        }
        public string AvgIncome(double FamAvg)
        {
            if (this.income > FamAvg / 0.1)
            {
                return "above avarge";
            }
            if (this.income / 0.1 < FamAvg)
            {
                return "below avarage";
            }
            return "avarage";
        }
        public void TeenGrow()
        {
            adults++;
            teenagers--;
        }
        public void ChildGrow()
        {
            teenagers++;
            child--; 
        }
        
    }

}
