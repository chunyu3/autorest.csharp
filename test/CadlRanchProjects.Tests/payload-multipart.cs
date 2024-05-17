using System;
using System.ClientModel.Primitives;
using System.IO;
using System.Threading.Tasks;
using AutoRest.TestServer.Tests.Infrastructure;
using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities;
using NUnit.Framework;
using Payload.MultiPart;
using Payload.MultiPart.Models;

namespace CadlRanchProjects.Tests
{
    public class PayloadMultipartTests : CadlRanchTestBase
    {
        private string SamplePngPath = Path.Combine(CadlRanchServer.GetSpecDirectory(), "assets", "image.png");
        private string SampleJpgPath = Path.Combine(CadlRanchServer.GetSpecDirectory(), "assets", "image.jpg");

        [Test]
        public Task Payload_Multipart_FormData_Basic() => Test(async (host) =>
        {
            MultiPartRequest body = new MultiPartRequest("123", File.OpenRead(SampleJpgPath));
            var response = await new MultiPartClient(host, null).GetFormDataClient().BasicAsync(body);
            Assert.AreEqual(204, response.Status);
        });

        [Test]
        public void Payload_Multipart_FormData_Basic_sync()
        {
            MultiPartRequest body = new MultiPartRequest("123", File.OpenRead(SampleJpgPath));
            BinaryData data = ModelReaderWriter.Write(body, new ModelReaderWriterOptions("MFD"));
            var lenght = data.ToArray().Length;
            var response = new MultiPartClient(new Uri("http://localhost:3000"), null).GetFormDataClient().Basic(body);
            Assert.AreEqual(204, response.Status);
        }

        [Test]
        public Task Payload_Multipart_FormData_JsonPart() => Test(async (host) =>
        {
            Address addressX = new Address("X");
            JsonPartRequest data = new JsonPartRequest(addressX, File.OpenRead(SampleJpgPath));
            var response = await new MultiPartClient(host, null).GetFormDataClient().JsonPartAsync(data);
            Assert.AreEqual(204, response.Status);
        });

        [Test]
        public Task Payload_Multipart_FormData_BinaryArrayParts() => Test(async (host) =>
        {
            var pictures = new Stream[]
            {
                File.OpenRead(SamplePngPath),
                File.OpenRead(SamplePngPath)
            };
            BinaryArrayPartsRequest data = new BinaryArrayPartsRequest("123", pictures);
            var response = await new MultiPartClient(host, null).GetFormDataClient().BinaryArrayPartsAsync(data);
            Assert.AreEqual(204, response.Status);
        });

        [Test]
        public Task Payload_Multipart_FormData_Anonymous_Model() => Test(async (host) =>
        {
            var response = await new MultiPartClient(host, null).GetFormDataClient().AnonymousModelAsync(File.OpenRead(SampleJpgPath));
            Assert.AreEqual(204, response.Status);
        });

        [TestCase(true)]
        [TestCase(false)]
        public Task Payload_Multipart_FormData_multiBinaryParts(bool hasPicture) => Test(async (host) =>
        {
            MultiBinaryPartsRequest data = new MultiBinaryPartsRequest(File.OpenRead(SampleJpgPath));
            if (hasPicture)
            {
                data.Picture = File.OpenRead(SamplePngPath);
            }
            var response = await new MultiPartClient(host, null).GetFormDataClient().MultiBinaryPartsAsync(data);
            Assert.AreEqual(204, response.Status);
        });
    }
}
