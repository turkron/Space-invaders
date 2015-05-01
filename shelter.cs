using UnityEngine;
using System.Collections;

public class shelter : MonoBehaviour
{

		public int hitsTaken = 0;
		public Texture2D[] textures;

		// Use this for initialization
		void Start ()
		{
	
		}
	
		// Update is called once per frame
		void Update ()
		{
				if (hitsTaken == 3) {
						Destroy (this.gameObject);
				}
				this.GetComponent<Renderer>().material.mainTexture = textures [hitsTaken];
				
		}
	
		void OnTriggerEnter2D (Collider2D whatHitMe)
		{
				if (whatHitMe.gameObject.tag == "Bullet" || whatHitMe.gameObject.tag == "SIBullet") {
						hitsTaken ++;
				}
				if (whatHitMe.gameObject.tag == "SpaceInvader") {
						Destroy (this.gameObject);
				}
	
		}
}
