using UnityEngine;
using System.Collections;

public class Arrays : MonoBehaviour 
{
	public GameObject[]players;

	void Start ()
	{
		players = GameObject.FindGameObjectsWithTag("Player");

		for(int i = 0; i < players.Length; i++)
		{
			Debug.Log("Player number " + (i + 1) + " is named " + players[i].name);
		}
	}
}
