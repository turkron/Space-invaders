using UnityEngine;
using System.Collections;

public class ScoreAsset : MonoBehaviour
{

		public string Name;
		public int Score;

		// Use this for initialization
		void Start ()
		{
				this.gameObject.GetComponent<TextMesh> ().text = Name + "          " + Score;
		}
	
		// Update is called once per frame
		void Update ()
		{
			
		}
}
