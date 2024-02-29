using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Testrepository.BL;
using Testrepository.DAL;

namespace Testrepository
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TSPBusiness tspBusiness = new TSPBusiness(new TSPRepository());
            bool isRunning = true;
            while (isRunning)
            {
                try
                {
                    Console.WriteLine("Please Type 'L' for List, 'A' for Add, 'U' for Update 'D' for Delete, 'S' for Search,'C' for Clear, 'E' for Exit");
                    string command = Console.ReadLine();
                    if (command == "L")
                    {
                        List<TSP> _listTSP = tspBusiness.Get();
                        Console.WriteLine("List of Students:");
                        Console.WriteLine("ID |   Name  | Address");
                        foreach (TSP _tsp in _listTSP)
                        {
                            Console.WriteLine(_tsp.TSPId + "  |  " + _tsp.TSPName + "  |  " + _tsp.TSPAddress);
                        }
                    }
                    else if (command == "S")
                    {
                        Console.WriteLine("Input a id to find a TSP:");
                        string id = Console.ReadLine();
                        TSP aTSP = tspBusiness.Get(Convert.ToInt32(id));
                        Console.WriteLine(aTSP.TSPId + ". " + aTSP.TSPName + " -- " + aTSP.TSPAddress);
                    }
                    else if (command == "A")
                    {
                        Console.WriteLine("Input a id:");
                        string id = Console.ReadLine();
                        Console.WriteLine("Input a name:");
                        string name = Console.ReadLine();
                        Console.WriteLine("Input a address:");
                        string address = Console.ReadLine();
                        TSP aTSP = new TSP();
                        aTSP.TSPId = Convert.ToInt32(id);
                        aTSP.TSPName = name;
                        aTSP.TSPAddress = address;
                        bool isExecuted = tspBusiness.Add(aTSP);
                        if (isExecuted)
                        {
                            Console.WriteLine("Added successfully.");
                        }
                        else
                        {
                            Console.WriteLine("Failed to add.");
                        }
                    }
                    else if (command == "U")
                    {
                        Console.WriteLine("Input a id:");
                        string id = Console.ReadLine();
                        Console.WriteLine("Input a name:");
                        string name = Console.ReadLine();
                        Console.WriteLine("Input a address:");
                        string address = Console.ReadLine();
                        TSP atsp = new TSP();
                        atsp.TSPId = Convert.ToInt32(id);
                        atsp.TSPName = name;
                        atsp.TSPAddress = address;
                        bool isExecuted = tspBusiness.Update(atsp);
                        if (isExecuted)
                        {
                            Console.WriteLine("Updated successfully.");
                        }
                        else
                        {
                            Console.WriteLine("Failed to update.");
                        }
                    }
                    else if (command == "D")
                    {
                        Console.WriteLine("Input a id:");
                        string id = Console.ReadLine();
                        bool isExecuted = tspBusiness.Delete(Convert.ToInt32(id));
                        if (isExecuted)
                        {
                            Console.WriteLine("Deleted successfully.");
                        }
                        else
                        {
                            Console.WriteLine("Failed to delete.");
                        }
                    }
                    else if (command == "C")
                    {
                        Console.Clear();
                    }
                    else if (command == "E")
                    {
                        isRunning = false;
                    }
                    else
                    {
                        Console.WriteLine("Please Enter valid Command .");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }

            }
            Console.ReadKey();  
        }
    }
    }

