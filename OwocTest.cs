// <copyright file="OwocTest.cs">Copyright ©  2020</copyright>

using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WindowsFormsApp2;

namespace WindowsFormsApp2.Tests
{
    [TestClass]
    [PexClass(typeof(Owoc))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class OwocTest
    {

        [PexMethod]
        internal bool czy_nowy_owoc(
            [PexAssumeUnderTest] Owoc target,
            int glowa_x,
            int glowa_y
        )
        {
            bool result = target.czy_nowy_owoc(glowa_x, glowa_y);
            return result;
            // TODO: dodaj asercje do metoda OwocTest.czy_nowy_owoc(Owoc, Int32, Int32)
        }
    }
}
