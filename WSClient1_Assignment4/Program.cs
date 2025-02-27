﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WSAssignment4;
using WSClient1_Assignment4;


namespace WSClient1_Assignment4
{
    class Program
    {


        static void Main(string[] args)
        {
            Errorhandler errorhandler = new Errorhandler();
            Assignment4Service proxy = new Assignment4Service();

            try
            {
                Account[] list = proxy.GetAccounts();

                foreach (Account a in list)
                {
                    Console.WriteLine("Username: " + a.Username + " " + "Name: " + a.Name + " " + "Surname: " + a.Surename);
                }

                SavingSchedule[] alist = proxy.GetSavingSchedules();

                foreach (SavingSchedule a in alist)
                {
                    Console.WriteLine("Username: " + a.AccountUsername + " Total Income: " + a.TotalIncome + " Fixed Cost: " + a.FixedCost + " Variable Cost: " + a.VariableCost + " Saving Goal: " + a.SavingGoal + " Saving Duration: " + a.SavingDuration);
                }

            }
            catch(Exception ex)
            {

                Console.WriteLine(errorhandler.HandleException(ex));
            }

          

            Console.ReadLine();

        }
    }
}
