using UnityEngine;
using System.Collections;
using NUnit.Framework;

public class TestCalculator {

	[Test]
	public void TestAdd(){
		Assert.That (Calculator.Add(1, 1) == 2);
	}
		
	[Test]
	public void TestAddFloat(){

		Assert.That((1.0001f+2.2221f),Is.EqualTo(Calculator.Add(1.0001f,2.2221f)));
	}

	[Test]
	public void TestSub()
	{
		Assert.That (Calculator.Sub(1, 1) == 0);
		Assert.That (Calculator.Sub(2, 1) == 1);
	}

	[Test]
	public void TestSumValues ( ){
		Assert.That (Calculator.Add( new int[]{ 1,2,3 }  ) == 6);
		Assert.That (Calculator.Add( new int[]{ 1,2,5 }  ) == 8);
	}

	[Test]
	public void TestSubstractValues ( ){
		Assert.That(-4,Is.EqualTo(Calculator.Sub(new int[]{1,2,3})));
		Assert.That (Calculator.Sub(new int[0]) == 0);

		Assert.That(0,Is.EqualTo(Calculator.Sub(null)));
		Assert.That(6,Is.EqualTo(Calculator.Mul(new int[]{1,2,3})));

	}


}
