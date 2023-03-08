using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lab4MySun : MonoBehaviour
{
	GameObject sun;
	GameObject[] mylights;
	void Start()
	{
		sun = GameObject.FindWithTag("sunlight");
		mylights = GameObject.FindGameObjectsWithTag("scenelight");
		foreach (GameObject mylight in mylights)
		{
			mylight.GetComponent<Light>().color = Color.red;
		}
	}

	void Update()
	{
		sun.transform.Rotate(Vector3.left * 30 * Time.deltaTime);
	}
}
