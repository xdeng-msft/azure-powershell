// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.Management.DevTestLabs
{
    using Microsoft.Rest.Azure;
    using Models;

    /// <summary>
    /// Extension methods for SchedulesOperations
    /// </summary>
    public static partial class SchedulesOperationsExtensions
    {
        /// <summary>
        /// List schedules in a given lab.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='odataQuery'>
        /// 
        /// </param>
        /// <param name='labName'>
        /// The name of the lab.
        /// </param>
        public static Microsoft.Rest.Azure.IPage<Schedule> List(this ISchedulesOperations operations, string labName, Microsoft.Rest.Azure.OData.ODataQuery<Schedule> odataQuery = default(Microsoft.Rest.Azure.OData.ODataQuery<Schedule>))
        {
                return ((ISchedulesOperations)operations).ListAsync(labName, odataQuery).GetAwaiter().GetResult();
        }

        /// <summary>
        /// List schedules in a given lab.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='odataQuery'>
        /// 
        /// </param>
        /// <param name='labName'>
        /// The name of the lab.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async System.Threading.Tasks.Task<Microsoft.Rest.Azure.IPage<Schedule>> ListAsync(this ISchedulesOperations operations, string labName, Microsoft.Rest.Azure.OData.ODataQuery<Schedule> odataQuery = default(Microsoft.Rest.Azure.OData.ODataQuery<Schedule>), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            using (var _result = await operations.ListWithHttpMessagesAsync(labName, odataQuery, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }
        /// <summary>
        /// Get schedule.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='labName'>
        /// The name of the lab.
        /// </param>
        /// <param name='name'>
        /// The name of the schedule.
        /// </param>
        /// <param name='expand'>
        /// Specify the $expand query. Example: &#39;properties($select=status)&#39;
        /// </param>
        public static Schedule Get(this ISchedulesOperations operations, string labName, string name, string expand = default(string))
        {
                return ((ISchedulesOperations)operations).GetAsync(labName, name, expand).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Get schedule.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='labName'>
        /// The name of the lab.
        /// </param>
        /// <param name='name'>
        /// The name of the schedule.
        /// </param>
        /// <param name='expand'>
        /// Specify the $expand query. Example: &#39;properties($select=status)&#39;
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async System.Threading.Tasks.Task<Schedule> GetAsync(this ISchedulesOperations operations, string labName, string name, string expand = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            using (var _result = await operations.GetWithHttpMessagesAsync(labName, name, expand, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }
        /// <summary>
        /// Create or replace an existing schedule.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='labName'>
        /// The name of the lab.
        /// </param>
        /// <param name='name'>
        /// The name of the schedule.
        /// </param>
        public static Schedule CreateOrUpdate(this ISchedulesOperations operations, string labName, string name, Schedule schedule)
        {
                return ((ISchedulesOperations)operations).CreateOrUpdateAsync(labName, name, schedule).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Create or replace an existing schedule.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='labName'>
        /// The name of the lab.
        /// </param>
        /// <param name='name'>
        /// The name of the schedule.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async System.Threading.Tasks.Task<Schedule> CreateOrUpdateAsync(this ISchedulesOperations operations, string labName, string name, Schedule schedule, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(labName, name, schedule, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }
        /// <summary>
        /// Delete schedule.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='labName'>
        /// The name of the lab.
        /// </param>
        /// <param name='name'>
        /// The name of the schedule.
        /// </param>
        public static void Delete(this ISchedulesOperations operations, string labName, string name)
        {
                ((ISchedulesOperations)operations).DeleteAsync(labName, name).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Delete schedule.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='labName'>
        /// The name of the lab.
        /// </param>
        /// <param name='name'>
        /// The name of the schedule.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async System.Threading.Tasks.Task DeleteAsync(this ISchedulesOperations operations, string labName, string name, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            (await operations.DeleteWithHttpMessagesAsync(labName, name, null, cancellationToken).ConfigureAwait(false)).Dispose();
        }
        /// <summary>
        /// Modify properties of schedules.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='labName'>
        /// The name of the lab.
        /// </param>
        /// <param name='name'>
        /// The name of the schedule.
        /// </param>
        public static Schedule Update(this ISchedulesOperations operations, string labName, string name, ScheduleFragment schedule)
        {
                return ((ISchedulesOperations)operations).UpdateAsync(labName, name, schedule).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Modify properties of schedules.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='labName'>
        /// The name of the lab.
        /// </param>
        /// <param name='name'>
        /// The name of the schedule.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async System.Threading.Tasks.Task<Schedule> UpdateAsync(this ISchedulesOperations operations, string labName, string name, ScheduleFragment schedule, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            using (var _result = await operations.UpdateWithHttpMessagesAsync(labName, name, schedule, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }
        /// <summary>
        /// Execute a schedule. This operation can take a while to complete.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='labName'>
        /// The name of the lab.
        /// </param>
        /// <param name='name'>
        /// The name of the schedule.
        /// </param>
        public static void Execute(this ISchedulesOperations operations, string labName, string name)
        {
                ((ISchedulesOperations)operations).ExecuteAsync(labName, name).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Execute a schedule. This operation can take a while to complete.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='labName'>
        /// The name of the lab.
        /// </param>
        /// <param name='name'>
        /// The name of the schedule.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async System.Threading.Tasks.Task ExecuteAsync(this ISchedulesOperations operations, string labName, string name, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            (await operations.ExecuteWithHttpMessagesAsync(labName, name, null, cancellationToken).ConfigureAwait(false)).Dispose();
        }
        /// <summary>
        /// Lists all applicable schedules
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='labName'>
        /// The name of the lab.
        /// </param>
        /// <param name='name'>
        /// The name of the schedule.
        /// </param>
        public static Microsoft.Rest.Azure.IPage<Schedule> ListApplicable(this ISchedulesOperations operations, string labName, string name)
        {
                return ((ISchedulesOperations)operations).ListApplicableAsync(labName, name).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Lists all applicable schedules
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='labName'>
        /// The name of the lab.
        /// </param>
        /// <param name='name'>
        /// The name of the schedule.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async System.Threading.Tasks.Task<Microsoft.Rest.Azure.IPage<Schedule>> ListApplicableAsync(this ISchedulesOperations operations, string labName, string name, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            using (var _result = await operations.ListApplicableWithHttpMessagesAsync(labName, name, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }
        /// <summary>
        /// Execute a schedule. This operation can take a while to complete.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='labName'>
        /// The name of the lab.
        /// </param>
        /// <param name='name'>
        /// The name of the schedule.
        /// </param>
        public static void BeginExecute(this ISchedulesOperations operations, string labName, string name)
        {
                ((ISchedulesOperations)operations).BeginExecuteAsync(labName, name).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Execute a schedule. This operation can take a while to complete.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='labName'>
        /// The name of the lab.
        /// </param>
        /// <param name='name'>
        /// The name of the schedule.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async System.Threading.Tasks.Task BeginExecuteAsync(this ISchedulesOperations operations, string labName, string name, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            (await operations.BeginExecuteWithHttpMessagesAsync(labName, name, null, cancellationToken).ConfigureAwait(false)).Dispose();
        }
        /// <summary>
        /// List schedules in a given lab.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        public static Microsoft.Rest.Azure.IPage<Schedule> ListNext(this ISchedulesOperations operations, string nextPageLink)
        {
                return ((ISchedulesOperations)operations).ListNextAsync(nextPageLink).GetAwaiter().GetResult();
        }

        /// <summary>
        /// List schedules in a given lab.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async System.Threading.Tasks.Task<Microsoft.Rest.Azure.IPage<Schedule>> ListNextAsync(this ISchedulesOperations operations, string nextPageLink, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }
        /// <summary>
        /// Lists all applicable schedules
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        public static Microsoft.Rest.Azure.IPage<Schedule> ListApplicableNext(this ISchedulesOperations operations, string nextPageLink)
        {
                return ((ISchedulesOperations)operations).ListApplicableNextAsync(nextPageLink).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Lists all applicable schedules
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async System.Threading.Tasks.Task<Microsoft.Rest.Azure.IPage<Schedule>> ListApplicableNextAsync(this ISchedulesOperations operations, string nextPageLink, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            using (var _result = await operations.ListApplicableNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }
    }
}
