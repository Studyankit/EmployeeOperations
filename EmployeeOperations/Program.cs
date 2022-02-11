// See https://aka.ms/new-console-template for more information
using EmployeeOperations.FinalSolution;

EmpWageBuilder empWageBuild = new EmpWageBuilder();
empWageBuild.addCompanyEmpWage("DMart", 20, 2, 10);
empWageBuild.addCompanyEmpWage("Reliance", 10, 4, 20);
empWageBuild.computeEmpWage();
Console.ReadKey();
