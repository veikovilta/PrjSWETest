Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting

<TestClass()> Public Class CSWETestComponent

    <TestMethod()> Public Sub CSWETestComponent_String_StringNoolteVahel()
        Dim test As New PrjSWEngineeringTest.CSWETestComponent
        Dim vastus = test.PubFunc("ASD", "A", True)
        Assert.AreEqual("<<<ASD>>>", vastus)
    End Sub

    <TestMethod()> Public Sub CSWETestComponent_String_str1pikemkuistr2()
        Dim test As New PrjSWEngineeringTest.CSWETestComponent
        Dim vastus = test.PubFunc("ASD", "A", False)
        Assert.AreEqual("ASD (3) > A (1)", vastus)
    End Sub
    <TestMethod()> Public Sub CSWETestComponent_String_str1luhemkuistr2()
        Dim test As New PrjSWEngineeringTest.CSWETestComponent
        Dim vastus = test.PubFunc("A", "AS", False)
        Assert.AreEqual("A (1) < AS (2)", vastus)
    End Sub
    <TestMethod()> Public Sub CSWETestComponent_String_vordsed()
        Dim test As New PrjSWEngineeringTest.CSWETestComponent
        Dim vastus = test.PubFunc("AS", "AS", False)
        Assert.AreEqual("VIGA", vastus)
    End Sub
    <TestMethod()> Public Sub CSWETestComponent_String_tuhi()
        Dim test As New PrjSWEngineeringTest.CSWETestComponent
        Dim vastus = test.PubFunc("", "AS", False)
        Assert.AreEqual("VIGA", vastus)
    End Sub

End Class