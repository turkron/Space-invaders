using UnityEngine;
using System.Collections;

public class GameOver1 : MonoBehaviour
{
	
		public int Timer = 250;
	
		// Use this for initialization
		void Start ()
		{
	
		}
	
		// Update is called once per frame
		void Update ()
		{
				Timer --;
				//if (Timer == 0)
				//Application.LoadLevel ("ScoreScreen");
		}
}
