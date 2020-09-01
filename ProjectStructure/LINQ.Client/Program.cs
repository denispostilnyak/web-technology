using System;
using System.Collections;
using System.Collections.Generic;
using LINQ.Client.Models;
using LINQ.Client.Services;
using Newtonsoft.Json;
using ProjectStructure.Client.Services;
using Task = System.Threading.Tasks.Task;

namespace LINQ.Client
{
    class Program
    {
        static TaskClientService taskClientService ;

        static void Main(string[] args)
        {
            string option;
            int parseOption = 0;
            int maxOptionValue = 9;
            int minOptionValue = 1;
            int id = 0;

            var queriesClientService = new QueriesClientService();

            while (true)
            {

                Console.WriteLine("Select LINQ task from 1 to 7:\n" + "1\n" + "2\n" + "3\n" + "4\n" + "5\n" + "6\n" + "7\n");
                Console.WriteLine("---------------------------------------------------------------------------------");
                Console.WriteLine("Or\n 8: CRUD operations\n 9: Finish random task" );

                Console.WriteLine("10: Exit\n");

                Console.WriteLine("Your choice: ");
                option = Console.ReadLine();
                try
                {
                    parseOption = Int32.Parse(option);
                }
                catch
                {
                    Console.WriteLine("Невірний вхідний формат! Спробуйте ще");
                    continue;
                }

                if (parseOption >= minOptionValue && parseOption <= maxOptionValue)
                {
                    switch (parseOption)
                    {
                        //case 1:
                        //    Console.WriteLine("Write user's id:");
                        //    try
                        //    {
                        //        id = int.Parse(Console.ReadLine());
                        //    }
                        //    catch (Exception e)
                        //    {
                        //        Console.WriteLine(e.Message);
                        //        return;
                        //    }

                        //    var result1 = await queriesClientService.GetTasksByUser(id);
                        //    Console.WriteLine("Result\t");
                        //    foreach (var item in result1)
                        //    {
                        //        Console.WriteLine(item.Key + ": " + item.Value);
                        //    }

                        //    break;
                        //case 2:
                        //    Console.WriteLine("Write user's id:");
                        //    try
                        //    {
                        //        id = int.Parse(Console.ReadLine());
                        //    }
                        //    catch (Exception e)
                        //    {
                        //        Console.WriteLine(e.Message);
                        //        return;
                        //    }

                        //    var result2 = await queriesClientService.GetTasksByUserCurrentYear(id);
                        //    foreach (var item in result2)
                        //    {
                        //        Console.WriteLine(item.Name);
                        //    }

                        //    break;
                        //case 3:
                        //    Console.WriteLine("Write user's id:");
                        //    try
                        //    {
                        //        id = int.Parse(Console.ReadLine());
                        //    }
                        //    catch (Exception e)
                        //    {
                        //        Console.WriteLine(e.Message);
                        //        return;
                        //    }

                        //    var result3 = await queriesClientService.GetTasksByUserNameCondition(id);
                        //    foreach (var item in result3)
                        //    {
                        //        Console.WriteLine(item.Name);
                        //    }

                        //    break;
                        //case 4:
                        //    var result4 = await queriesClientService.GetTeamsOrderTenYears();
                        //    foreach (var item in result4)
                        //    {
                        //        Console.WriteLine(item.Item2);
                        //        foreach (var subItem in item.Item3)
                        //        {
                        //            Console.WriteLine(subItem.FirstName + "\n");
                        //        }
                        //    }

                        //    break;
                        //case 5:
                        //    var result5 = await queriesClientService.GetUsersSortedByNameAndTasks();
                        //    foreach (var item in result5)
                        //    {
                        //        Console.WriteLine(item.FirstName);
                        //    }

                        //    break;
                        //case 6:
                        //    Console.WriteLine("Write user's id:");
                        //    try
                        //    {
                        //        id = int.Parse(Console.ReadLine());
                        //    }
                        //    catch (Exception e)
                        //    {
                        //        Console.WriteLine(e.Message);
                        //        return;
                        //    }

                        //    var result6 = await queriesClientService.GetLastProjectCountAndLongerTasks(id);
                        //    Console.WriteLine(result6.LastProject.Name + "," + result6.CountTasksPerLastProject);
                        //    break;
                        //case 7:
                        //    var result7 = await queriesClientService.GetProjectLogestAndShortestTaskAndUsersAmount();
                        //    foreach (var item in result7)
                        //    {
                        //        Console.WriteLine(item.UsersAmountFilteredByProjectProperties + "," +
                        //                          item.Project.Name + "," + item.LongestTaskByDescription.Name);
                        //    }

                        //    break;
                        case 8:
                             CrudOperations();
                            break;
                        case 9:
                            taskClientService = new TaskClientService();
                            taskClientService.MarkRandomTaskWithDelay(1000);
                            break;
                        case 10:
                            return;
                    }

                }
                else
                {
                    Console.WriteLine("Values must be beetween 1 and 7");
                    continue;
                }
            }
        }
       
        static async Task CrudOperations()
        {
            Console.WriteLine("Choose Type which you want to do with \n 1: Project\n 2: Task \n 3: Team \n 4:User");
            Console.WriteLine("\n Your choise: ");
            var opt = Int32.Parse(Console.ReadLine());
            switch (opt)
            {
                case 1:
                    await SendRequest<Project>();
                    break;
                case 2:
                    await SendRequest<Task>();
                    break;
                case 3:
                    await SendRequest<Team>();
                    break;
                case 4:
                    await SendRequest<User>();
                    break;
            }
        }

        static async Task SendRequest<T>()
        {
            var crudLogicService = new CrudLogicService();

            Console.WriteLine("Choose operation:\n 1: Create \n 2: Read \n 3: Update \n 4: Delete");
            Console.WriteLine("\n Your choise: ");
            try
            {
                var opt = Int32.Parse(Console.ReadLine());
                switch (opt) {
                    case 1:
                        Console.WriteLine("Enter body in json: \n");
                        var bodyStringCreate = Console.ReadLine();
                        var bodyCreate = JsonConvert.DeserializeObject<T>(bodyStringCreate);
                        await crudLogicService.Create<T>(bodyCreate);
                        break;
                    case 2:
                        await crudLogicService.Get<T>();
                        break;
                    case 3:
                        Console.WriteLine("Enter body in json: \n"); 
                        var bodyStringUpdate = Console.ReadLine();
                        var bodyUpdate = JsonConvert.DeserializeObject<T>(bodyStringUpdate);
                        await crudLogicService.Update<T>(bodyUpdate);
                        break;
                    case 4:
                        Console.WriteLine("Enter id: \n");
                        var id = Int32.Parse(Console.ReadLine());
                        await crudLogicService.Delete<T>(id);
                        break;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}