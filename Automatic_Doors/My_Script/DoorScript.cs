using UnityEngine;

public class DoorScript : MonoBehaviour {

	public GameObject leftDoor;
	public GameObject rightDoor;

	Animator leftAnim;
	Animator rightAnim;

	void Start () {
		leftAnim = leftDoor.GetComponent <Animator> ();
		rightAnim = rightDoor.GetComponent <Animator> ();
	}
	
	void OnTriggerEnter(Collider coll){
		if (coll.tag == "Player") {
			SlideDoors (true);
		}
	}

	void OnTriggerExit(Collider coll){
		if (coll.tag == "Player") {
			SlideDoors (false);
		}
	}
		
	void SlideDoors(bool state){
		leftAnim.SetBool ("slide", state);
		rightAnim.SetBool ("slide", state);
	}

//end o class
}
