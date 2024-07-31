using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class NewTestScript
{
    [Test]
    public void NewTestScriptSimplePasses()
    {
        Assert.AreEqual(5, 0);
    }

    [Test]
    public void NewTestScriptSimplePasses2()
    {
        Assert.AreEqual(5, 5);
    }

    [UnityTest]
    public IEnumerator NewTestScriptWithEnumeratorSimplePasses()
    {
        yield return new WaitForSeconds(3);
        Assert.AreEqual(5, 5);
    }
}
