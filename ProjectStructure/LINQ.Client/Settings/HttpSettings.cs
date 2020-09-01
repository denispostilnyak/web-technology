using System;
using System.Collections.Generic;
using System.Text;

namespace LINQ.Client.Settings
{
    public static class HttpSettings
    {
        public static string Host { get; } = "http://localhost:44366/";
        public static string ApiEndpoint { get; } = "api/";

        public static string ProjectsByIdEndpoint { get; } = "project/";
        public static string ProjectsEndpoint { get; } = "project";

        public static string TasksByIdEndpoint { get; } = "task/";
        public static string TasksEndpoint { get; } = "task";
        public static string FinishTaskEndpoint { get; } = "finish";


        public static string TeamsByIdEndpoint { get; } = "team/";
        public static string TeamsEndpoint { get; } = "team";

        public static string UsersByIdEndpoint { get; } = "user/";
        public static string UsersEndpoint { get; } = "user";

        public static string QueriesEndpoint { get; } = "queries/";
        public static string TasksByUser { get; } = "tasksByUser/";

        public static string TasksByUserPropertyName { get; } = "tasksByUserPropertyName/";

        public static string TasksByUserAndYear { get; } = "tasksByUserAndYear/";

        public static string TeamsOrderTenYears { get; } = "teamsOrderTenYears";

        public static string UsersSortedByProperties { get; } = "usersSortedByProperties";

        public static string LastProjectCountAndLongerTasks { get; } = "lastProjectCountAndLongerTasks/";

        public static string ProjectLongestAndShortestTaskAndUsersAmount { get; } = "projectLongestAndShortestTaskAndUsersAmount";


    }
}
