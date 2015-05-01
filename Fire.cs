using UnityEngine;
using System.Collections;

public class Fire : MonoBehaviour
{

		public int upperShotRange;
		public int lowerShotRange;
		public int myShotTime;
		public int Timer;
		public GameObject SIBullet;

		// Use this for initialization
		void Start ()
		{
				myShotTime = Random.Range (lowerShotRange, upperShotRange);
		}
	
		// Update is called once per frame
		void Update ()
		{
				if (PlayerMovement.statee == "Alive") {
						Timer ++;
						if (Timer == myShotTime) {
								Instantiate (SIBullet, this.transform.position, this.transform.rotation);
								//myShotTime = Random.Range (lowerShotRange, upperShotRange);
						}
						if (Timer == upperShotRange) {
								myShotTime = Random.Range (lowerShotRange, upperShotRange);
								Timer = 0;
						}
				
				}
				
		}
}
