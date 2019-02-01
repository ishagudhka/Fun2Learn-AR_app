using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChooseMenu : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void LoadArabicLetter()
	{
		Application.LoadLevel ("AR firstSene");
	}

	public void LoadArabicNum()
	{
		Application.LoadLevel ("AR ArabicNum Scene");
	}

	public void LoadEnglishLetter()
	{
		Application.LoadLevel ("AR EngLetter Scene");
	}

	public void LoadEnglishNum()
	{
		Application.LoadLevel ("AR EngNum Scene");
	}

	public void LoadEnglishAnimal()
	{
		Application.LoadLevel ("AR EnglishAnimal Scene");
	}

	public void LoadArabicAnimal()
	{
		Application.LoadLevel ("AR ArabicAnimal Scene");
	}
}
