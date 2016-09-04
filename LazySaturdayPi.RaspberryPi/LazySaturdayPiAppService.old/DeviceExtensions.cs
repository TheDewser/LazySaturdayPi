﻿// Code generated by Microsoft (R) AutoRest Code Generator 0.9.7.0
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using LazySaturdayPi.RaspberryPi;
using Microsoft.Rest;

namespace LazySaturdayPi.RaspberryPi
{
    public static partial class DeviceExtensions
    {
        /// <param name='operations'>
        /// Reference to the LazySaturdayPi.RaspberryPi.IDevice.
        /// </param>
        /// <param name='deviceId'>
        /// Required.
        /// </param>
        public static bool Post(this IDevice operations, string deviceId)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IDevice)s).PostAsync(deviceId);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <param name='operations'>
        /// Reference to the LazySaturdayPi.RaspberryPi.IDevice.
        /// </param>
        /// <param name='deviceId'>
        /// Required.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        public static async Task<bool> PostAsync(this IDevice operations, string deviceId, CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Microsoft.Rest.HttpOperationResponse<bool> result = await operations.PostWithOperationResponseAsync(deviceId, cancellationToken).ConfigureAwait(false);
            return result.Body;
        }
    }
}
