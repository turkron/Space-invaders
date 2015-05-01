using UnityEngine;
using System.Collections;

public class SpaceInvader : MonoBehaviour
{

		public Texture2D frame1;
		public Texture2D frame2;
		public int currentFrame = 1;
		public bool movedDownYet = false;
		public static GameObject boundaryName;
		public GameObject DParticle;

		// Use this for initialization
		void Start ()
		{
	
		}
	
		// Update is called once per frame
		void Update ()
		{
	
		}

		public void FakeUpdate (string command)
		{

				if (currentFrame == 1) {
						this.GetComponent<Renderer>().material.mainTexture = frame2;
						currentFrame = 2;
				} else {
						this.GetComponent<Renderer>().material.mainTexture = frame1;
						currentFrame = 1;
				}
				if (command == "Move Left") {
						this.transform.Translate (-0.10f, 0f, 0f);
						movedDownYet = false;
				}
				if (command == "Move Right") {
						this.transform.Translate (0.10f, 0f, 0f);
						movedDownYet = false;
				}
				if (command == "Move Down") {
						this.transform.Translate (0f, -0.10f, 0f);
						movedDownYet = true;
				}
		
		
		}

		void OnTriggerEnter2D (Collider2D whathitme)
		{
				if (whathitme.gameObject.tag == "Bullet") {
						GameObject.Find ("Main Camera").GetComponent<GameLoop> ().SIarray.Remove (this.gameObject);
						GameObject.Destroy (this.gameObject);
						GameLoop.Score += 10;
						Instantiate (DParticle, this.transform.position, this.transform.rotation);
				}
				
				if (whathitme.gameObject.tag == "Player" || whathitme.gameObject.tag == "Shelter") {
						GameObject.Find ("Main Camera").GetComponent<GameLoop> ().SIarray.Remove (this.gameObject);
						Destroy (this.gameObject);
				}
		}

		void OnTriggerStay2D (Collider2D whatHitMe)
		{

				//print ("HITME");
				if (whatHitMe.gameObject.tag == "Boundary" && GameLoop.SIMovementCommand != "Move Down") {
						GameLoop.SIMovementCommand = "Move Down";
						boundaryName = whatHitMe.gameObject;
				}
		

		}
}
