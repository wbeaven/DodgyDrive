using UnityEngine;

public class Win : MonoBehaviour 
{
	public GameObject winScreen;
	void OnTriggerEnter ()
	{
		winScreen.SetActive(true);
	}

}
