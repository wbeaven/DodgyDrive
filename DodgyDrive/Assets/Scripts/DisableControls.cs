using UnityEngine;

public class DisableControls : MonoBehaviour 
{
	public bool firstTrigger;
	public bool secondTrigger;
	public int carMass;
	public bool isLevel1;
	public bool isLevel2;
	private void OnTriggerEnter(Collider other)
	{
		if (firstTrigger == true)
        {
			other.GetComponent<LookAtMouse>().enabled = false;
			other.GetComponent<Rigidbody>().mass = carMass;
			other.GetComponent<MoveToMouse>().carSound.SetActive(false);
			if (isLevel1)
				StaticData.levelOnePath = 1;
        }
        if (secondTrigger == true)
        {
			other.GetComponent<MoveToMouse>().enabled = false;
		}
	}
}
