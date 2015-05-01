using UnityEngine;
using System.Collections;

public class reset : MonoBehaviour
{

		// Use this for initialization
		void Start ()
		{
	
		}
	
		// Update is called once per frame
		void Update ()
		{
	
		}
	
		void OnMouseUp ()
		{
	
				Application.LoadLevel ("StartScreen");
				shooting.numberOfBullets = 0;
				GameLoop.Score = 0;
				GameLoop.SIMovementCommand = "Move Right";
				GameLoop.Lifes = 3;
				SpaceInvader.boundaryName = null;
				PlayerMovement.statee = "Alive";
		}
	
	
}
