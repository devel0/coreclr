using System;
using System.Collections.Generic;
/// <summary>
///ctor(System.String,System.Exception)
/// </summary>
public class NotSupportedExceptionCtor3
{
    public static int Main()
    {
        NotSupportedExceptionCtor3 NotSupportedExceptionCtor3 = new NotSupportedExceptionCtor3();

        TestLibrary.TestFramework.BeginTestCase("NotSupportedExceptionCtor3");
        if (NotSupportedExceptionCtor3.RunTests())
        {
            TestLibrary.TestFramework.EndTestCase();
            TestLibrary.TestFramework.LogInformation("PASS");
            return 100;
        }
        else
        {
            TestLibrary.TestFramework.EndTestCase();
            TestLibrary.TestFramework.LogInformation("FAIL");
            return 0;
        }
    }
    public bool RunTests()
    {
        bool retVal = true;
        TestLibrary.TestFramework.LogInformation("[Positive]");
        retVal = PosTest1() && retVal;
        retVal = PosTest2() && retVal;
        return retVal;
    }
    // Returns true if the expected result is right
    // Returns false if the expected result is wrong
    public bool PosTest1()
    {
        bool retVal = true;
        TestLibrary.TestFramework.BeginScenario("PosTest1: Create a new instance of NotSupportedException.");
        try
        {
            string expectValue = "HELLO";
            ArgumentException notFoundException = new ArgumentException();
            NotSupportedException myException = new NotSupportedException(expectValue, notFoundException);
            if (myException == null)
            {
                TestLibrary.TestFramework.LogError("001.1", "NotSupportedException instance can not create correctly.");
                retVal = false;
            }
            if (myException.Message != expectValue)
            {
                TestLibrary.TestFramework.LogError("001.2", "the Message should return " + expectValue);
                retVal = false;
            }
            if (!(myException.InnerException is ArgumentException))
            {
                TestLibrary.TestFramework.LogError("001.3", "the InnerException should return ArgumentException.");
                retVal = false;
            }
        }
        catch (Exception e)
        {
            TestLibrary.TestFramework.LogError("001.0", "Unexpected exception: " + e);
            retVal = false;
        }
        return retVal;
    }
    // Returns true if the expected result is right
    // Returns false if the expected result is wrong
    public bool PosTest2()
    {
        bool retVal = true;
        TestLibrary.TestFramework.BeginScenario("PosTest2: the parameter string is null.");
        try
        {
            string expectValue = null;
            ArgumentException dpoExpection = new ArgumentException();
            NotSupportedException myException = new NotSupportedException(expectValue, dpoExpection);
            if (myException == null)
            {
                TestLibrary.TestFramework.LogError("002.1", "NotSupportedException instance can not create correctly.");
                retVal = false;
            }
            if (myException.Message == expectValue)
            {
                TestLibrary.TestFramework.LogError("002.2", "the Message should return the default value.");
                retVal = false;
            }
            if (!(myException.InnerException is ArgumentException))
            {
                TestLibrary.TestFramework.LogError("002.3", "the InnerException should return NotSupportedException.");
                retVal = false;
            }
        }
        catch (Exception e)
        {
            TestLibrary.TestFramework.LogError("002.0", "Unexpected exception: " + e);
            retVal = false;
        }
        return retVal;
    }
}
