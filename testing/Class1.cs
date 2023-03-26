using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POE_Task2
{
    // creating the car class 
    internal class Car
    {
        //the car variables
        string modelAndMake;
        double purchasePrice;
        double totalDeposit;
        double interestRate;
        double estimatedInsurancePremium;
        double monthlyCost;

        //creating setters and getters
        public string getModelAndMake()
        {
            return modelAndMake;
        }

        public void setModelAndMake()
        {
            //prompt
            //input
            Console.WriteLine("Enter the Model and make >>");
           string modelAndMake = Console.ReadLine();
            this.modelAndMake =  modelAndMake;
        }

        public double getPurchasePrice()
        {
            
            return purchasePrice;
           
        }

        public void setPurchasePrice()
        {
            Console.WriteLine("Enter the Purchase Price >>");
            double purchasePrice = Convert.ToInt32(Console.ReadLine());
            this.purchasePrice =  purchasePrice;
        }

        public double getTotalDeposit()
        {
            
            return totalDeposit;
        }

        public void setTotalDeposit()
        {
            Console.WriteLine("Enter the Total deposit >>");
            double totalDeposit = Convert.ToInt32(Console.ReadLine());

            this.totalDeposit = totalDeposit;
        }

        public double getinterestRate ()
        {
            
            return interestRate;
        }

        public void setInterestRate()
        {
            Console.WriteLine("Enter the interest rate >>");
            double interestRate = Convert.ToInt32(Console.ReadLine());
            this.interestRate = interestRate;
        }

        public double getEstimatedInsurancePremium()
        {
            
            return estimatedInsurancePremium;
        }

        public void setEstimatedInsurancePremium()
        {
            Console.WriteLine("Enter the Estimated insurance premium >>");
            double estimatedInsurancePremium = Convert.ToInt32(Console.ReadLine());
            this.estimatedInsurancePremium = estimatedInsurancePremium;
        }
        public virtual double myTotalMonthlyCost()
        {
            //making the calculations for the monthly cost
             monthlyCost = estimatedInsurancePremium + (purchasePrice *(interestRate /5));

            Console.WriteLine("The total monthly cost of the car is: R" + monthlyCost);

            return monthlyCost;
        }


    }
}

