using UnityEngine;
using System.Collections;

public class opening : MonoBehaviour 
{
	public Texture2D menu;
	private bool menu_pressed = false;

	public Texture2D slide_1;
	public Texture2D slide_2;
	public Texture2D slide_3;
	public Texture2D slide_4;
	public Texture2D slide_5;
	public Texture2D slide_6;

	static public Rect basic;

	private float length = 600f;

	// Use this for initialization
	void Start () 
	{
		basic = new Rect(0f, 0f, Screen.width,Screen.height);
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(Input.GetKeyDown("return"))
		{
			menu_pressed = true;
		}

		if(length <= 0)
		{
			Application.LoadLevel("Main_Game");
		}
	}

	void OnGUI()
	{
		if(menu_pressed == false)
		{
			GUI.DrawTexture (basic, menu);
		}
		else
		{
			if(length > 0f && length <= 100f)
			{
				GUI.DrawTexture (basic, slide_6);
			}
			else if(length > 100f && length <= 200f)
			{
				GUI.DrawTexture (basic, slide_5);
			}
			else if(length > 200f && length <= 300f)
			{
				GUI.DrawTexture (basic, slide_4);
			}
			else if(length > 300f && length <= 400f)
			{
				GUI.DrawTexture (basic, slide_3);
			}
			else if(length > 400f && length <= 500f)
			{
				GUI.DrawTexture (basic, slide_2);
			}
			else if(length > 500f && length <= 600f)
			{
				GUI.DrawTexture (basic, slide_1);
			}

			length = length - 0.2f;
		}
	}
}
