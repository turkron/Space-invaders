using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GameLoop : MonoBehaviour
{

		public float moveTimer = 0;
		public float moveTriggerLimit = 200;
		public GameObject SI1;
		public GameObject SI2;
		public GameObject SI3;
		public List<GameObject> SIarray;
		public static string SIMovementCommand = "Move Right";
		public float bonusTimer = 0;
		public float bonusTimerTrigger = 500;
		public GameObject bonusShip;
		public static int Score = 0;
		public static int Lifes = 3;
		
		public AudioClip[] SIMovement;
		public int audioFile = 1;

		public bool GameOver = false;

		// Use this for initialization
		void Start ()
		{

				// instantiate all SI here;
				for (int y = 0; y < 6; y++) {
						for (int x = 0; x < 10; x++) {

								if (y == 0) {
										GameObject newSI = (GameObject)Instantiate (SI1, new Vector2 (-5.3f - (-1.1f * x), 3.679384f - y), Quaternion.Euler (0, 0, 0));
										SIarray.Add (newSI);
								}
								if (y == 1) {
										GameObject newSI1 = (GameObject)Instantiate (SI2, new Vector2 (-5.3f - (-1.1f * x), 4f - y), Quaternion.Euler (0, 0, 0));
										SIarray.Add (newSI1);
								}
								if (y == 2) {
										GameObject newSI2 = (GameObject)Instantiate (SI3, new Vector2 (-5.3f - (-1.1f * x), 4.2f - y), Quaternion.Euler (0, 0, 0));
										SIarray.Add (newSI2);
								}
								if (y == 3) {
										GameObject newSI = (GameObject)Instantiate (SI1, new Vector2 (-5.3f - (-1.1f * x), 4.5f - y), Quaternion.Euler (0, 0, 0));
										SIarray.Add (newSI);
								}
								if (y == 4) {
										GameObject newSI1 = (GameObject)Instantiate (SI2, new Vector2 (-5.3f - (-1.1f * x), 4.8f - y), Quaternion.Euler (0, 0, 0));
										SIarray.Add (newSI1);
								}
								if (y == 5) {
										GameObject newSI2 = (GameObject)Instantiate (SI3, new Vector2 (-5.3f - (-1.1f * x), 5f - y), Quaternion.Euler (0, 0, 0));
										SIarray.Add (newSI2);
								}

						}
				}
	
		}
	
		// Update is called once per frame
		void FixedUpdate ()
		{
				if (Lifes == 0) {
						GameOver = true;
				}
					
				if (!GameOver) {
						if (SIarray.Count == 0) {
								Lifes ++;
								if (Lifes == 5) {
										Lifes = 4;
								}
								shooting.numberOfBullets = 0;
								Application.LoadLevel ("Game");
								
						}
						if (PlayerMovement.statee == "Alive") {
								//print (shooting.numberOfBullets);
								moveTimer ++;
								bonusTimer ++;
								if (moveTimer == moveTriggerLimit) {
										//loop through SIarray to call FakeUpdate ();
										foreach (GameObject i in SIarray) {
					
												if (i.GetComponent<SpaceInvader> ().movedDownYet == true && SIMovementCommand == "Move Down") {
														if (SpaceInvader.boundaryName.GetComponent<boundary> ().leftBoundary == true) {
																SIMovementCommand = "Move Right";
														} else {
																SIMovementCommand = "Move Left";
														}
														if (moveTriggerLimit > 10) {
																moveTriggerLimit -= 5;
														}
												}
										
										
						
												i.GetComponent<SpaceInvader> ().FakeUpdate (SIMovementCommand);
										}
										moveTimer = 0;
										GetComponent<AudioSource>().PlayOneShot (SIMovement [audioFile]);
										audioFile ++;
										if (audioFile == SIMovement.Length) {
												audioFile = 0;
										}
								
								}
					
								if (bonusTimer == bonusTimerTrigger) {
										int randomSide = Random.Range (1, 3);
										if (randomSide == 1) {
												GameObject bonus1 = (GameObject)Instantiate (bonusShip, new Vector2 (-7.961894f, 4.639676f), Quaternion.Euler (0, 0, 0));
												bonus1.gameObject.GetComponent<bonusShip> ().movement = "Move Right";
										}
										if (randomSide == 2) {
												GameObject bonus2 = (GameObject)Instantiate (bonusShip, new Vector2 (7.961894f, 4.639676f), Quaternion.Euler (0, 0, 0));
												bonus2.gameObject.GetComponent<bonusShip> ().movement = "Move Left";
										}
										print (randomSide);
										print ("ship spawned");
										bonusTimer = 0;					
								}
						}

				} else {

						Application.LoadLevel ("GameOver");
				}

		}
}
