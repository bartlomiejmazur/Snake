using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WindowsFormsApp2;
// <copyright file="OwocTest.czy_nowy_owoc.g.cs">Copyright ©  2020</copyright>
// <auto-generated>
// Ten plik zawiera testy generowane automatycznie.
// Nie należy ręcznie modyfikować tego pliku.
// 
// Jeśli zawartość tego pliku stanie się nieaktualna, można go usunąć.
// Stanie się tak na przykład wtedy, gdy plik przestanie się kompilować.
// </auto-generated>
using System;

namespace WindowsFormsApp2.Tests
{
    public partial class OwocTest
    {

[TestMethod]
[PexGeneratedBy(typeof(OwocTest))]
public void czy_nowy_owoc811()
{
    Owoc owoc;
    bool b;
    owoc = new Owoc(0);
    owoc.x = 0;
    owoc.y = 0;
    owoc.segment = 0;
    b = this.czy_nowy_owoc(owoc, 0, 0);
    Assert.IsNotNull((object)owoc);
}

[TestMethod]
[PexGeneratedBy(typeof(OwocTest))]
public void czy_nowy_owoc540()
{
    Owoc owoc;
    bool b;
    owoc = new Owoc(0);
    owoc.x = 0;
    owoc.y = 0;
    owoc.segment = 0;
    b = this.czy_nowy_owoc(owoc, 0, int.MinValue);
    Assert.IsNotNull((object)owoc);
}

[TestMethod]
[PexGeneratedBy(typeof(OwocTest))]
public void czy_nowy_owoc973()
{
    Owoc owoc;
    bool b;
    owoc = new Owoc(0);
    owoc.x = 0;
    owoc.y = 0;
    owoc.segment = 0;
    b = this.czy_nowy_owoc(owoc, int.MinValue, 0);
    Assert.IsNotNull((object)owoc);
}
    }
}
