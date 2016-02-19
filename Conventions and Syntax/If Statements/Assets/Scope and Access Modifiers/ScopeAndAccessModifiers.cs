using UnityEngine;
using System.Collections;

public class ScopeAndAccessModifiers : MonoBehaviour 
{
	public int num1 = 3;
	public int num2 = 4;
	
	private int num3 = 5;
	
	void Start ()
	{
		int answer;
		answer = num1 * num3;
		Debug.Log(answer);
	}
}