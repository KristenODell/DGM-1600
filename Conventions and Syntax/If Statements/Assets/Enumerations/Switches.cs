using UnityEngine;
using System.Collections;

public class Switches : MonoBehaviour 
{
	public int intelligence = 2;
	
	void Greet ()
	{
		switch(intelligence)
		{
		case 2:
			print("Hello");
			break;
		case 1:
			print("Hi");
			break;
		default:
			print("Error");
			break;
		}
	}
	void Start()
	{
		Greet();
	}
}