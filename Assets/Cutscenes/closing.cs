using UnityEngine;
using System.Collections;

public class closing : MonoBehaviour 
{
	public Texture2D slide_1;
	public Texture2D slide_2;
	public Texture2D slide_3;

	public AudioClip starting;
	public AudioClip next;
	
	static public Rect basic;
	
	private float length = 420f;

	private int i = 1;
	
	// Use this for initialization
	void Start () 
	{
		basic = new Rect(0f, 0f, Screen.width,Screen.height);
		audio.clip = starting;
		audio.Play();
	}
	
	// Update is called once per frame
	void Update () 
	{
		length = length - 0.09f;
		
		if(length <= 0)
		{
			Application.Quit();
		}
	}
	
	void OnGUI()
	{
		if(length > 0f && length <= 290f)
		{
			GUI.DrawTexture (basic, slide_3);
			if(i == 1)
			{
				audio.clip = next;
				audio.Play();
				i = 2;
			}
		}
		else if(length > 290f && length <= 390f)
		{
			GUI.DrawTexture (basic, slide_2);
		}
		else if(length > 390f && length <= 450f)
		{
			GUI.DrawTexture (basic, slide_1);
		}
	}
}