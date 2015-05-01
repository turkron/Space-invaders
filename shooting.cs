using UnityEngine;
using System.Collections;

public class shooting : MonoBehaviour
{
	
		public static int numberOfBullets = 0;
		public GameObject bullet;
		public AudioClip shot;
		
			
		// Use this for initialization
		void Start ()
		{
	
		}
	
		// Update is called once per frame
		void Update ()
		{
	
				if (Input.GetKeyDown (KeyCode.Space) && numberOfBullets == 0 && PlayerMovement.statee == "Alive") {
						Instantiate (bullet, this.transform.position, Quaternion.Euler (0, 0, 0));
						GetComponent<AudioSource>().PlayOneShot (shot);
						
				}
	
		}
}
