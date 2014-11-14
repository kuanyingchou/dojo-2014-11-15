using UnityEngine;
using System.Collections;
using System;
public static class Calculator{



	public static int Add(int a, int b)
	{
		return a + b;
	}

	public static float Add(float a, float b)
	{
		return a + b;
	}

	public static int Sub(int a,int b){
		return a - b;
	}

	public static float Sub(int[] values){

		return Calculate ((a,b)=>a-b ,values);
	}


	public static int Add(int[] values) {
		return Calculate ((a,b)=>a+b ,values);

	}

	public static int Mul(int[] values) {
		return Calculate ((a,b)=>a*b ,values);
		
	}




	public static int Calculate(Func<int,int,int> func,int[] values){

		if (values == null||values.Length == 0)
			return 0;
		
		int result = values [0];
		for (int i=1; i<values.Length; i++) {
			result=func(result,values[i]);
		}
		return result;
		
	}
}
