﻿using UnityEngine;
using System.Collections;

public class Enumerations : MonoBehaviour 
{
	enum Direction {North, East, South, West};

	void Start ()
	{
		Direction myDirection;

		myDirection = Direction.North;

		myDirection = ReverseDirection (myDirection);
		Debug.Log (myDirection);
	}

	Direction ReverseDirection (Direction dir)
	{
		if (dir == Direction.North)
			dir = Direction.South;
		else if (dir == Direction.South)
			dir = Direction.North;
		else if (dir == Direction.East)
			dir = Direction.West;
		else if (dir == Direction.West)
			dir = Direction.East;

		return dir;
	}
}

