using UnityEngine;
using System.Collections;


public class bulletTravel : MonoBehaviour
{
		
		
		public float movementSpeed = 0.1f;

		// Use this for initialization
		void Start ()
		{
				shooting.numberOfBullets ++;
		}
	
		// Update is called once per frame
		void Update ()
		{
				if (PlayerMovement.statee == "Alive")
						this.transform.Translate (0, movementSpeed, 0);
				else {
						Destroy (this.gameObject);
						shooting.numberOfBullets --;
				}
	
		}
		
		void OnTriggerEnter2D (Collider2D whathitme)
		{
				if (whathitme.gameObject.tag == "Roof") {
						shooting.numberOfBullets --;
						Destroy (this.gameObject);
				}
				if (whathitme.gameObject.tag == "SpaceInvader" || whathitme.gameObject.tag == "BonusShip") {
						shooting.numberOfBullets --;
						Destroy (this.gameObject);
				}
				if (whathitme.gameObject.tag == "Shelter") {
						shooting.numberOfBullets --;
						Destroy (this.gameObject);
				}
		}
		
}