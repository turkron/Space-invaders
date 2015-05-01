using UnityEngine;
using System.Collections;

public class SIbullet : MonoBehaviour
{

		public Texture2D frame1;
		public Texture2D frame2;
		public int currentFrame = 1;
		public int frameTimer = 0;
		public int frameTimerTrigger = 20;
		public float movementSpeed = 0.1f;
		public float lifespan = 200;

		// Use this for initialization
		void Start ()
		{
	
		}
	
		// Update is called once per frame
		void Update ()
		{
				lifespan --;
				if (lifespan == 0) {
						Destroy (this.gameObject);
				
				}
				
				if (PlayerMovement.statee == "Dead") {
						Destroy (this.gameObject);
				}	
			
				frameTimer ++;
				if (frameTimer >= frameTimerTrigger) {			
						if (currentFrame == 1) {
								this.GetComponent<Renderer>().material.mainTexture = frame2;
								currentFrame = 2;
						} else {
								this.GetComponent<Renderer>().material.mainTexture = frame1;
								currentFrame = 1;
						}
						frameTimer = 0;
				}
				this.transform.Translate (0f, -movementSpeed, 0f);
		}
		
		void OnTriggerEnter2D (Collider2D whathitme)
		{	
				//print ("HITME!");
				if (whathitme.gameObject.tag == "Shelter") {
						Destroy (this.gameObject);
				}
				
		}
}
