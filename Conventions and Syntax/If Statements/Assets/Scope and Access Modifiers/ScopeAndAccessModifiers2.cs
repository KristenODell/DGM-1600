using UnityEngine;
using System.Collections;

public class ScopeAndAccessModifiers2 : MonoBehaviour 
{
	public int num = 5;
	
	ScopeAndAccessModifiers Hi;
	
	void Start ()
	{
		Hi = GetComponent<ScopeAndAccessModifiers>();
		int answer;
		answer = num * Hi.num1;
		Debug.Log(answer);
	}
}