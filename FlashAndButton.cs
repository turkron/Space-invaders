using UnityEngine;
using System.Collections;

public class FlashAndButton : MonoBehaviour
{

		public int Timer = 50;

		// Use this for initialization
		void Start ()
		{
	
		}
	
		// Update is called once per frame
		void Update ()
		{
		
				Timer --;
				if (Timer == 0) {
						if (this.GetComponent<Renderer>().enabled == true) {
								this.GetComponent<Renderer>().enabled = false;
						} else {
								this.GetComponent<Renderer>().enabled = true;
						}
						Timer = 50;
				}
	
		}
		void OnMouseDown ()
		{
				Application.LoadLevel ("Game");
		}
}
