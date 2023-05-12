using System;
using System.Linq;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using _Specs_.Azure.Core.Lro.Standard;
using _Specs_.Azure.Core.Lro.Standard.Models;
using AutoRest.TestServer.Tests.Infrastructure;
using Azure;
using Azure.Core;
using NUnit.Framework;

namespace CadlRanchProjects.Tests {
    public class AzureCoreLroStandardTests : CadlRanchTestBase {

        [Test]
        public Task Azure_Core_Lro_Standard_CreateOrReplace2() => Test(async (host) =>
        {
            User user = new User("contributor");
            Operation<User> operation = await new StandardClient(host, null).CreateOrReplaceAsync(WaitUntil.Completed, "madge", user);
            Assert.AreEqual((int)HttpStatusCode.OK, operation.GetRawResponse().Status);
        });

        [Test]
        public Task Azure_Core_Lro_Standard_CreateOrReplace([Values(WaitUntil.Started, WaitUntil.Completed)] WaitUntil waitUntil) => Test(async (host) =>
        {
            User user = new User("contributor");
            Operation<User> operation = await new StandardClient(host, null).CreateOrReplaceAsync(WaitUntil.Started, "madge", user);
            var result = WaitForCompletionWithValue(operation, waitUntil);
            Assert.AreEqual((int)HttpStatusCode.OK, result.GetRawResponse().Status);
        });

        private static Response WaitForCompletion(Operation operation, WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            var operationHasCompleted = waitUntil == WaitUntil.Completed;
            if (operationHasCompleted)
            {
                Assert.IsTrue(operation.HasCompleted);
                return operation.GetRawResponse();
            }

            return operation.WaitForCompletionResponse(TimeSpan.FromSeconds(1), cancellationToken);
        }
        private static Response<TResult> WaitForCompletionWithValue<TResult>(Operation<TResult> operation, WaitUntil waitUntil, CancellationToken cancellationToken = default) where TResult : notnull
        {
            var operationHasCompleted = waitUntil == WaitUntil.Completed;
            if (operationHasCompleted)
            {
                Assert.IsTrue(operation.HasCompleted);
                return Response.FromValue(operation.Value, operation.GetRawResponse());
            }

            return operation.WaitForCompletion(TimeSpan.FromSeconds(1), cancellationToken);
        }
    }
}
