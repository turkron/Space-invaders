using UnityEngine;
using System.Collections;

public class bonusShip : MonoBehaviour
{
	
		public string movement;
		public float movementSpeed;
		public float lifeSpan = 300;
		public GameObject Dparticle;
	
		// Use this for initialization
		void Start ()
		{
	
		}
	
		// Update is called once per frame
		void Update ()
		{
				lifeSpan --;
				if (lifeSpan < 0) {
						Destroy (this.gameObject);
				}
		
				if (movement == "Move Left") {
						this.transform.Translate (-movementSpeed, 0, 0);
				} else {
						this.transform.Translate (movementSpeed, 0, 0);
				}
		}
		
		void OnTriggerEnter2D (Collider2D whathitme)
		{
				if (whathitme.gameObject.tag == "Bullet") {
						GameObject.Destroy (this.gameObject);
						GameLoop.Score += GameObject.Find ("Main Camera").GetComponent<GameLoop> ().SIarray.Count * 10;
						Instantiate (Dparticle, this.transform.position, this.transform.rotation);
						//instantiate death particle here.
				}
		}
}
