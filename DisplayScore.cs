using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class DisplayScore : MonoBehaviour
{

		public List<GameObject> scoreArray;
		public List<int> Scores; 
		public GameObject scoreAsset;

		// Use this for initialization
		void Start ()
		{
		
				scoreArray.Sort ();
					
				for (int y = 0; y < 6; y++) {
						GameObject temp = (GameObject)Instantiate (scoreAsset, new Vector2 (-2f, 1.627162f - y), Quaternion.Euler (Vector3.zero));
						temp.gameObject.GetComponent<ScoreAsset> ().Score = Scores [y];
						scoreArray.Add (temp);
				}
				
				//scoreArray.Sort ();
	
		}
	
		// Update is called once per frame
		void Update ()
		{
	
		}
}
