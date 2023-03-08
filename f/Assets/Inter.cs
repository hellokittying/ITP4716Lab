using UnityEngine;
using System.Collections;
using UnityStandardAssets.Characters.FirstPerson;

public class Inter : MonoBehaviour
{

	GameObject player;

	void Start()
	{
		player = GameObject.FindWithTag("Player");
		player.GetComponent<FirstPersonController>().enabled = false;
	}
}