using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour
{

		public bool canMoveRight = true;
		public bool canMoveLeft = true;
		public float movementSpeed = 0.01f;
		public static string statee = "Alive";
		
		public Texture2D[] textures;
		
		public int currentTexture = 1;
		public int textureTimer = 0;
		public int textureTrigger = 20;
		public int deathTimer = 0;
		public int deathTriggerLimit = 75;
		
		public AudioClip deathSound;
		
		// Use this for initialization
		void Start ()
		{
	
		}
	
		// Update is called once per frame
		void Update ()
		{
				if (statee == "Alive") {
						textureTimer = 0;
						this.GetComponent<Renderer>().material.mainTexture = textures [0];
				
						if (Input.GetKey (KeyCode.RightArrow)) {
								if (canMoveRight) {
										this.transform.Translate (movementSpeed, 0, 0);
								}
						}
						if (Input.GetKey (KeyCode.LeftArrow)) {
								if (canMoveLeft) {
										this.transform.Translate (-movementSpeed, 0, 0);
								}
						}
				
				}
				
				if (statee == "Dead") {
						textureTimer ++;
						deathTimer ++;
						this.GetComponent<Renderer>().material.mainTexture = textures [currentTexture];
						if (textureTimer >= textureTrigger) {
								if (currentTexture == 1) {
										currentTexture = 2;
										textureTimer = 0;
								} else {
										currentTexture = 1;
										textureTimer = 0;
								}
						}
						if (deathTimer >= deathTriggerLimit) {
								deathTimer = 0;
								statee = "Alive";
								this.transform.position = new Vector2 (0, this.transform.position.y);
						}
				}
	
		}
		
		void OnTriggerEnter2D (Collider2D somethinghitme)
		{
				if (somethinghitme.gameObject.tag == "SIBullet" && statee == "Alive") {
						statee = "Dead";
						GameLoop.Lifes --;
						GetComponent<AudioSource>().PlayOneShot (deathSound);
				}
				
				if (somethinghitme.gameObject.tag == "SpaceInvader" && statee == "Alive") {
						statee = "Dead";
						GameLoop.Lifes --;
						GetComponent<AudioSource>().PlayOneShot (deathSound);
				
				}
		
		}

		void OnTriggerStay2D (Collider2D whatHitMe)
		{
				print ("HIT ME");
				

				if (whatHitMe.gameObject.tag == "Boundary") {
						if (whatHitMe.gameObject.GetComponent<boundary> ().leftBoundary == true) {
								this.canMoveLeft = false;
						}
						if (whatHitMe.gameObject.GetComponent<boundary> ().rightBoundary == true) {
								this.canMoveRight = false;
						}

				}
		}
		void OnTriggerExit2D (Collider2D a)
		{
				if (a.gameObject.tag == "Boundary") {
						this.canMoveLeft = true;
						this.canMoveRight = true;
				}

		}
}
