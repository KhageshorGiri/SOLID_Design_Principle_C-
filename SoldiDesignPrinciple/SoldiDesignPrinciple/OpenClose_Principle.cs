using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoldiDesignPrinciple
{


    //The Open/closed Principle says "A software module/class is open for extension and closed for modification".
    //Following this principle is essential for writing code that is easy to maintain and revise.Your class complies with this principle if it is:
    //    1. Open for extension, meaning that the class’s behavior can be extended; and
    //    2. Closed for modification, meaning that the source code is set and cannot be changed.

    //The idea of Open-Closed Principle is that existing, well-tested classes will need to be modified when somenhing needs to be added.
    //Yet, changing classes can lead to problem or bugs. Insted of changing the class, you simply extent it and add other features.
    //With that goal in mind, Martin summarizes this principle.


       // ## Let's draw a example

    public class EmployeeBonus
    {
        public double CalcuateBonus(string empType, double salary)
        {
            double bonus = 0;
            if(empType == "CompanyEmployee")
            {
                bonus = (salary * 60) / 100;
            }
            else if (empType == "ContractEmployee")
            {
                bonus = (salary * 20) / 100;
            }
            return bonus;
        }

    }

    // In above class if we want to clacualte the bonus for third party employee then we need to modifi our CalculateBNonus method.
    // According to Our open/closed principle we cannot modifiy existing class to add feature we have to extend that class further to add other features.
    // 

    // Refactoring above class to add other features

    public abstract class Bonus
    {
        public abstract double CaluclateBonus(double salary);
    }

    public class CompanyEmployee : Bonus
    {
        public override double CaluclateBonus(double salary)
        {
           return (salary * 60) / 100;
        }
    }

    public class ContractEmployee : Bonus
    {
        public override double CaluclateBonus(double salary)
        {
            return (salary * 20) / 100;
        }
    }

    public class ThirdParty : Bonus
    {
        public override double CaluclateBonus(double salary)
        {
            return 0;
        }
    }

    // Like this we can extend existing class with out changing its orginal contains for adding others features.

    public class OpenClose_Principle
    {
    }
}
