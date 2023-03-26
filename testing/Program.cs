using System;
namespace POE_Task2
//Pheagane Ramosa 
//PROG TASK 1 
{
    //creating an abstract for the expenses
    public class Expenses
    {

        //Declaration of the Array
        double[] expenses = new double[7];


        //Variables Declared

        double monthlyIncome;
        double monthlyTax;
        double groceries;
        double waterandlights;
        double travel;
        double telephone;
        double oExpenses;
        double expenditures;
        double totalExpenses;


        double moneyLeft;


        //Gross Monthly Income
        public virtual double grossMonthlyIncome()
        {
            //Promt for GROSS MONTHLY INCOME
            Console.WriteLine("Enter your Gross Monthly Income(Before deductions) >>");
            expenses[0] = Convert.ToInt32(Console.ReadLine());
            monthlyIncome = expenses[0];
            return monthlyIncome;

        }


        //Monthly Tax Deduction
        public virtual double myMonthlyTaxDeduction()
        {
            //Promt for MONTHLY TAX DEDUCTIONS
            Console.WriteLine("Enter your Monthly Tax Deduction >>");
            expenses[1] = Convert.ToInt32(Console.ReadLine());
            monthlyTax = expenses[1];
            return monthlyTax;

        }

        //Groceries 
        public virtual double myGroceries()
        {
            //Promt for GROCERIES
            Console.WriteLine("Please enter the  monthly expenditures starting with the Groceries >> ");
            expenses[2] = Convert.ToInt32(Console.ReadLine());
            groceries = expenses[2];
            return groceries;

        }

        //Water and Lights
        public virtual double myWaterLights()
        {
            //Promt for WATER AND LIGHTS
            Console.WriteLine("Enter your amount for Water and Lights expenses >> ");
            expenses[3] = Convert.ToInt32(Console.ReadLine());
            waterandlights = expenses[3];
            return waterandlights;
        }

        //Travel Cost
        public virtual double myTravelCost()
        {
            //Promt for TRAVEL COST
            Console.WriteLine("Enter your amount for Travel expenses >> ");
            expenses[4] = Convert.ToInt32(Console.ReadLine());
            travel = expenses[4];
            return travel;

        }

        //Cell Phone and/or Telephone expenses
        public virtual double myTelephone()
        {
            //Promt for CELL PHONE AND TELEPHONE
            Console.WriteLine("Enter your amount for Cell Phone and/or Telephone expenses >> ");
            expenses[5] = Convert.ToInt32(Console.ReadLine());
            telephone = expenses[5];
            return telephone;
        }

        //Other expenses
        public virtual double myOtherExp()
        {
            //Promt for OTHER EXPENSES
            Console.WriteLine("Enter your amount for other expenses >> ");
            expenses[6] = Convert.ToInt32(Console.ReadLine());
            oExpenses = expenses[6];
            return oExpenses;

            expenditures = groceries + waterandlights + travel + telephone + oExpenses;

            Console.WriteLine("The  monthly expenditures is: R" + expenditures);
        }

        //********************************************************

        //available Money after the deductions
        public virtual double myAvalMoney()
        {
            moneyLeft = (monthlyIncome - (monthlyTax + groceries + waterandlights + travel + telephone + oExpenses));

            Console.WriteLine("The Available Money is: R" + moneyLeft);

            return moneyLeft;
        }

    }
    //*****************************************


    //Derived Class homeLoan Inherited from Expenses
    public class HomeLoan : Expenses
    {

        //Delaring variables:
        double purchasePrice;
        double TotalDeposit;
        double InterestRate;
        double Months;

        //Declaring The Monthly Repayments:
        double MonthlyRepayments = 0;

        //Declaring the Array
        double[] propertyData = new double[4];



        //the purchase Price method
        public virtual double PurchP()
        {
            Console.WriteLine("Please enter the pruchase price of the property:");
            propertyData[0] = Convert.ToInt32(Console.ReadLine());
            purchasePrice = propertyData[0];
            return purchasePrice;

        }

        //total amount Deposit method
        public virtual double totalDep()
        {
            Console.WriteLine("Please enter the Total Deposit:");
            propertyData[1] = Convert.ToInt32(Console.ReadLine());
            TotalDeposit = propertyData[1];
            return TotalDeposit;
        }

        //interest rate method
        public virtual double interestR()
        {
            Console.WriteLine("Please enter the Interest Rate as a Decimal (eg: 0.50 = 50%):");
            InterestRate = Convert.ToInt32(Console.ReadLine());
            InterestRate = InterestRate / 100;
            InterestRate = propertyData[2];
            return InterestRate;

        }

        //months method
        public virtual double months()
        {
            Console.WriteLine("Please enter the number of Months to repay, between 240 - 360:");
            propertyData[3] = Convert.ToInt32(Console.ReadLine());
            Months = propertyData[3];
            return Months;
        }
        //**************************************************************************************************************************************************************************************

        //Calculation for the monthly home repayments
        public Double repayments()
        {

            propertyData[0] = propertyData[1] * (1 + (propertyData[2] * propertyData[3]));

            MonthlyRepayments = propertyData[0] / 12;

            if (MonthlyRepayments > (1 / 3) * (propertyData[0]))
            {
                Console.WriteLine("Approval for home loan is unlikely." + "\nThe monthly repayments will be:" + MonthlyRepayments);
                return 0;
            }
            else
            {
                Console.WriteLine("The Monthly Repayments are: R" + MonthlyRepayments);
                return MonthlyRepayments;
            }
        }
    }
    //*****************************************************************************************


    //driver CLASS
    class Program : HomeLoan
    {

        //driver Method
        static void Main(string[] args)
        {
            //creating an object for the car
            Car myCar = new Car();

            Expenses myExpenses = new Expenses();


            HomeLoan calc = new HomeLoan();

            //Promt for GROSS MONTHLY INCOME
            calc.grossMonthlyIncome();

            //Promt for MONTHLY TAX DEDUCTIONS
            calc.myMonthlyTaxDeduction();

            //Promt for GROCERIES
            calc.myGroceries();

            //Promt for WATER AND LIGHTS
            calc.myWaterLights();

            //Promt for TRAVEL COST
            calc.myTravelCost();

            //Promt for CELL PHONE AND TELEPHONE
            calc.myTelephone();

            //Promt for OTHER EXPENSES
            calc.myOtherExp();


            //**************************************************************************************************************************************************************************************

            

            //Variable declared to be used in the IF statement to create a Decision
            int Choice1;


            //Promt to ask if the user is going to rent or buy a property.
            Console.WriteLine("Are you renting or buying a property?" +
                "\nEnter 1 if you are Renting then press enter." +
                "\nEnter 2 if you are Buying a property then press enter." +
                "\nEnter 3 if you want to see the available monthly money."+
            "\nEnter 4 if you want to rent a car");
            Choice1 = Convert.ToInt32(Console.ReadLine());


            HomeLoan BP = new HomeLoan();

            //If statement to determine if the user is going to buy or rent a property.
            if (Choice1 == 1)
            {
                Console.WriteLine("Enter the rent amount");

                //Declaring rent variable
                double rentProperty = Convert.ToInt32(Console.ReadLine());

                //Display Rent Amount

                Console.WriteLine("The Rent Amount is: R" + rentProperty + "per Month");
            }
            if (Choice1 == 2)
            {
                //Purchase Price
                BP.PurchP();

                //Total Deposit
                BP.totalDep();

                //Interest Rate
                BP.interestR();

                //Months
                BP.months();

                //Monthly Home Repayments
                BP.repayments();
            }
            //Display AVAILABLE MONEY
            if (Choice1 == 3)
            {
                calc.myAvalMoney();
            }
            if(Choice1 == 4)
            {
                myCar.setModelAndMake();
                myCar.setPurchasePrice();
                myCar.setTotalDeposit();
                myCar.setInterestRate();
                myCar.setEstimatedInsurancePremium();
                myCar.myTotalMonthlyCost();

                if ((calc.myAvalMoney() + myCar.myTotalMonthlyCost()) < (myExpenses.grossMonthlyIncome()/0.075))
                {


                    Console.WriteLine(" total expenses exceed 75% of your income");   // Outputs 
                }
                if ((calc.myAvalMoney() + myCar.myTotalMonthlyCost()) > (myExpenses.grossMonthlyIncome() / 0.075))
                {
                    Console.WriteLine(" total expenses does not exceed 75% of your income");   // Outputs 
                }
                {

                }
            }
        }
    }
    //***************************************************************************************
    //REFERENCE//
    //Troelsen, A. and Japikse, P. 2021. 
    //Pro C# 9 with .NET . 10th ed.
    //New York: Apress.
}

