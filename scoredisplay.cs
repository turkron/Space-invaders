using UnityEngine;
using System.Collections;

public class scoredisplay : MonoBehaviour
{

		// Use this for initialization
		void Start ()
		{
	
		}
	
		// Update is called once per frame
		void Update ()
		{
	
				this.GetComponent<TextMesh> ().text = "Your Final Score: " + GameLoop.Score;
	
		}
}
