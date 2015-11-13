using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {
	
	public GameObject target;
	public float rotateSpeed = 1;
	public float sensitivity;
	Vector3 offset;
	
	void Start() {
		offset = target.transform.position - transform.position;
	}
	
	void LateUpdate() {
		float horizontal = Input.GetAxis("Right Stick X") * rotateSpeed;
		//target.transform.Rotate(0, horizontal, 0);

		Quaternion rotation = Quaternion.Euler(0, horizontal*sensitivity, 0);
		transform.position = target.transform.position - (rotation*offset);
		
		transform.LookAt(target.transform);
	}
}