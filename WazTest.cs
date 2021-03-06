// <copyright file="WazTest.cs">Copyright ©  2020</copyright>

using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WindowsFormsApp2;

namespace WindowsFormsApp2.Tests
{
    [TestClass]
    [PexClass(typeof(Waz))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class WazTest
    {

        [PexMethod]
        internal void dodaj([PexAssumeUnderTest] Waz target)
        {
            target.dodaj();
            // TODO: dodaj asercje do metoda WazTest.dodaj(Waz)
        }
    }
}
