// This script is used for Impaired by Lauren Stamp
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionObject : MonoBehaviour
{
    // checks if item can be put it inventory, if it is openable, if it is locked, or if it is a medkit
	public bool inventory;
	public bool openable;
	public bool locked, isKey;
	public bool isMedkit;
	public GameObject itemNeeded;

	public Animator anim;

    void Update()
    {
    }

	public void DoInteraction()
	{
		gameObject.SetActive (false);
	}

	public void Open()
	{
		anim.SetBool ("open", true);
	}
    // checks if item is a key
    public bool IsKey()
    {
        return isKey;
    }
    // checks if item is a medkit
    public bool IsMedkit()
    {
        return isMedkit;
    }
}
