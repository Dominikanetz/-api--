﻿using System.Security.Cryptography.X509Certificates;
using FairMark.TrueApi.Toolbox;
using NUnit.Framework;

namespace FairMark.TrueApi.Tests
{
    [TestFixture]
    public class GostCryptoHelpersTests : UnitTestsBase
    {
        private X509Certificate2 GetTestCertificate()
        {
            return GostCryptoHelpers.FindCertificate(TestCertificateSubjectName);
        }

        [Test]
        public void GostCryproProviderIsInstalled()
        {
            Assert.IsTrue(GostCryptoHelpers.IsGostCryptoProviderInstalled());
        }

        [Test]
        public void CertificateIsLoadedByThumbprint()
        {
            var cert = GostCryptoHelpers.FindCertificate(TestCertificateThumbprint);
            Assert.NotNull(cert);
        }

        [Test]
        public void CertificateWithPrivateKeyIsLoaded()
        {
            var cert = GetTestCertificate();
            Assert.IsNotNull(cert);
            Assert.AreEqual(cert.Thumbprint.ToUpper(), TestCertificateThumbprint.ToUpper());
        }

        [Test]
        public void CertificateCanBeUsedToComputeDetachedCmsSignature()
        {
            var cert = GetTestCertificate();
            var sign = GostCryptoHelpers.ComputeDetachedSignature(cert, "Привет!");
            Assert.IsNotNull(sign);
            Assert.IsTrue(sign.StartsWith("MII"));
            Assert.IsTrue(sign.Length > 1000);
        }

        [Test]
        public void CertificateCanBeUsedToComputeAttachedCmsSignature()
        {
            var cert = GetTestCertificate();
            var sign = GostCryptoHelpers.ComputeAttachedSignature(cert, "Привет!");
            Assert.IsNotNull(sign);
            Assert.IsTrue(sign.StartsWith("MII"));
            Assert.IsTrue(sign.Length > 1000);
        }
    }
}
