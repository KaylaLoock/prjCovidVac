using System;
using System.Collections.Generic;
using System.Text;

namespace prjCovidVac
{
    class printDetails
    {
        public void PrintItems()
        {



            info A = new info();

            Console.Clear();
            //Asking user 
            Console.WriteLine("HOSPITAL REPORT\n---------------------------------------------------");
            Console.WriteLine("Hospital name " + A.getHospital_Name());
            Console.WriteLine("Hospital name " + A.getAddress());
            Console.WriteLine("Hospital name " + A.getHospitalPUBPRIV());
            Console.WriteLine("---------------------------------------------------");
            //wanting to loop the array
            for (int x = 0; x < A.size(); x++)
            {
                Console.WriteLine("PATIENT REPORT\n---------------------------------------------------");
                Console.WriteLine("ID Number : " + A.getIDNumber(x) +
                    "\nMedical Aid: " + A.getMedicalAid(x) +
                    "\nName: " + A.getName(x) +
                    "\nSurname: " + A.getSurname(x) +
                    "\nRefering Dr: " + A.getRefDr(x) +
                    "\nAllergies: " + A.getAllergies(x) +
                    "\nHad covid: " + A.getCovidPostive(x) +
                    "\nVaccine brand : " + A.getVaccine(x));
                Console.WriteLine("---------------------------------------------------");


            }

        }
    }
}
