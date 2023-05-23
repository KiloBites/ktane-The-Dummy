using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using KModkit;
using static UnityEngine.Random;
using static UnityEngine.Debug;

public class TheDummyScript : MonoBehaviour {

	public KMBombInfo Bomb;
	public KMAudio Audio;
	public KMBombModule Module;

	static int moduleIdCounter = 1;
	int moduleId;
	private bool moduleSolved;

	private static readonly string[] bodyParts =
	{
		"hair", "R thumb F", "R cheek", "R fourth T", "L index F", "L big T",
		"L fourth T", "nose", "L ring F", "R eye", "R armpit", "R pinky F",
		"L eye", "L elbow", "mouth", "R index F", "R ear", "R big T",
		"R middle T", "L ear", "L pinky T", "chin", "L pinky F", "L thumb F",
		"L middle F", "R elbow", "L cheek", "R nipple", "neck", "L nipple",
		"R knee", "R middle F", "R pinky T", "privates", "L armpit", "heart",
		"L middle T", "L knee", "R ring F", "R second T", "B button", "L second T"
	};

	private bool leftEye, rightEye;

	private List<string> partsToPress = new List<string>();

	void Awake()
    {

		moduleId = moduleIdCounter++;

		/*
		foreach (KMSelectable button in Buttons)
			button.OnInteract() += delegate () { ButtonPress(button); return false; };
		*/

		//Button.OnInteract += delegate () { ButtonPress(); return false; };

    }

	
	void Start()
    {

    }

	void calculatingBodyParts()
	{
		var sn = Bomb.GetSerialNumber().ToCharArray();
		int pos;

		pos = leftEye && rightEye ? 5 : !leftEye && !rightEye ? 36 : !leftEye && rightEye ? 0 : 41;

		partsToPress.Add(bodyParts[pos]);

		for (int i = 0; i < 6; i++)
		{

		}
	}
	
	
	void Update()
    {

    }

	// Twitch Plays


#pragma warning disable 414
	private readonly string TwitchHelpMessage = @"!{0} something";
#pragma warning restore 414

	IEnumerator ProcessTwitchCommand (string command)
    {
		string[] split = command.ToUpperInvariant().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries);
		yield return null;
    }

	IEnumerator TwitchHandleForcedSolve()
    {
		yield return null;
    }


}





