using UnityEngine;
using System.Collections;

public class DeathParticle : MonoBehaviour
{

		public float lifeSpan = 0;
		public float deathTrigger = 50;
		public AudioClip death;

		// Use this for initialization
		void Start ()
		{
				//lifeSpan = GameObject.Find ("Main Camera").GetComponent<GameLoop> ().moveTimer;
				//deathTrigger = GameObject.Find ("Main Camera").GetComponent<GameLoop> ().moveTriggerLimit;
				GetComponent<AudioSource>().PlayOneShot (death);
		}
	
		// Update is called once per frame
		void Update ()
		{
				lifeSpan ++;
				if (lifeSpan > deathTrigger) {
						Destroy (this.gameObject);
				}
				
	
		}
}
