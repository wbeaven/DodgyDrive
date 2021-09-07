using UnityEngine;

public class Win : MonoBehaviour 
{
	public GameObject winScreen;
	public GameObject stopSound;
	public bool isLevel1;
	public bool isLevel2;
	private void OnTriggerEnter(Collider other)
	{
		other.GetComponent<LookAtMouse>().enabled = false;
		other.GetComponent<MoveToMouse>().enabled = false;
		other.GetComponent<MoveToMouse>().carSound.SetActive(false);
		stopSound.SetActive(true);
		winScreen.SetActive(true);
		if (isLevel1)
			StaticData.levelOneComplete = 1;
  //      else
  //      {
		//	StaticData.levelTwoComplete = 1;
		//}
	}
}
