using UnityEngine;
using System.Collections;

public class ClassesandDatatypes : MonoBehaviour 
{
	public class Stuff
	{
		public int bullets;
		public int grenades;
		public int rockets;
		
		public Stuff (int bul, int gre, int rock)
		{
			bullets = bul;
			grenades = gre;
			rockets = rock;
		}
		
		public Stuff ()
		{
			bullets = 1;
			grenades = 1;
			rockets = 1;
		}
	}
	
	public Stuff myStuff = new Stuff(50, 5, 5);
	
	void Start ()
	{
		Debug.Log(myStuff.bullets);
	}
}