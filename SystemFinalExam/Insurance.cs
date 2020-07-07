using System;
using System.Collections.Generic;
using System.Text;

namespace SystemFinalExam
{   
    /// <summary>
    /// We implement the Factory Pattern in 'Insurance' class. Each Insurance package should have many provider.
    /// Using Factory Pattern let passenger decide which package they want to purchase.
    /// The 'Product' class - Factory Pattern
    /// </summary>
    public abstract class Insurance
    {
        public abstract int Price
        {
            get; set;
        }
        public abstract string Feature
        {
            get; set;
        }
        public abstract string InsuranceType
        {
            get; set;
        }
     
    }
    /// <summary>
    /// A 'Concrete Product' Class
    /// </summary>
    class NormalInsurance : Insurance
    {
        private string insuranceType;
        private int price;
        private string feature;      
        public override int Price { get => price; set => price = value; }
        public override string Feature { get => feature; set => feature = value; }
        public override string InsuranceType { get => insuranceType; set => insuranceType = value; }
        public NormalInsurance(int price, string feature)
        {
            this.Price = price;
            this.Feature = feature;
            this.InsuranceType = "Normal Insurance";
        }
    }
    /// <summary>
    /// A 'Concrete Product' Class
    /// </summary>
    class AdvancedInsurance : Insurance
    {
        private string insuranceType;
        private int price;
        private string feature;

        public AdvancedInsurance(int price, string feature)
        {
            this.Price = price;
            this.Feature = feature;
            this.InsuranceType = "Advanced Insurance";
        }
        public override int Price { get => price; set => price = value; }
        public override string Feature { get => feature; set => feature = value; }
        public override string InsuranceType { get => insuranceType; set => insuranceType = value; }
    }
    /// <summary>
    /// The 'Creator' Abstract Class
    /// </summary>
    abstract class InsuranceFactory
    {
        public abstract Insurance GetInsurance();
    }
    /// <summary>
    /// A 'Concrete Creator' Class
    /// </summary>
    class NormalInsuranceProvider : InsuranceFactory
    {
        private int price;
        private string feature;
        public int Price
        {
            get => price;
            set => price = value;
        }
        public string Feature
        {
            get => feature;
            set => feature = value;
        }

        public NormalInsuranceProvider(int price, string feature) 
        {
            this.Price = price;
            this.Feature = feature;
        }
        public override Insurance GetInsurance()
        {
            return new NormalInsurance(this.Price, this.Feature);
        }
    }
    /// <summary>
    /// A 'Concrete Creator' Class
    /// </summary>
    class AdvancedInsuranceProvider : InsuranceFactory
    {
        private int price;
        private string feature;
        public int Price
        {
            get => price;
            set => price = value;
        }
        public string Feature
        {
            get => feature;
            set => feature = value;
        }

        public AdvancedInsuranceProvider(int price, string feature)
        {
            this.Price = price;
            this.Feature = feature;
        }
        public override Insurance GetInsurance()
        {
            return new AdvancedInsurance(this.Price, this.Feature);
        }
    }

}
