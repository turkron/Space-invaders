using UnityEngine;
using System.Collections;

public class LifeDisplay : MonoBehaviour
{

		public int myLifeDisplay;

		// Use this for initialization
		void Start ()
		{
	
		}
	
		// Update is called once per frame
		void Update ()
		{
				if (GameLoop.Lifes >= myLifeDisplay) {
						this.GetComponent<Renderer>().enabled = true;
				} else {
						this.GetComponent<Renderer>().enabled = false;
				}
		}
}
