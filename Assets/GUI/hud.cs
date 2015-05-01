using UnityEngine;
using System.Collections;

public class hud : MonoBehaviour 
{
	public Texture2D fe_profile;
	public Texture2D bat_profile;
	public Texture2D R_profile;

	public Texture2D hot_keys;

	public Texture2D health0;
	public Texture2D health1;
	public Texture2D health2;
	public Texture2D health3;
	public Texture2D health4;
	public Texture2D health5;
	public Texture2D health6;
	public Texture2D health7;
	public Texture2D health8;
	public Texture2D health9;

	static public Rect basic;

	public float hp = 10f;

	// References to game controller script
	private master_script master_script;
	
	// Use this for initialization
	void Start () 
	{
		// Find and initialize game controller script so it can be referenced later
		master_script = GameObject.Find("master_index").GetComponent <master_script> ();

		basic = new Rect(0f, 0f, Screen.width,Screen.height);
	}
	void OnGUI () 
	{
		GUI.depth = 5;
		if(hp < 0f)
		{
			GUI.DrawTexture (basic, health0);
		}
		else if(hp > 0f && hp <= 100f)
		{
			GUI.DrawTexture (basic, health1);
		}
		else if(hp > 100f && hp <= 200f)
		{
			GUI.DrawTexture (basic, health2);
		}
		else if(hp > 200f && hp <= 300f)
		{
			GUI.DrawTexture (basic, health3);
		}
		else if(hp > 300f && hp <= 400f)
		{
			GUI.DrawTexture (basic, health4);
		}
		else if(hp > 400f && hp <= 500f)
		{
			GUI.DrawTexture (basic, health5);
		}
		else if(hp > 500f && hp <= 600f)
		{
			GUI.DrawTexture (basic, health6);
		}
		else if(hp > 600f && hp <= 700f)
		{
			GUI.DrawTexture (basic, health7);
		}
		else if(hp > 700f && hp <= 800f)
		{
			GUI.DrawTexture (basic, health8);
		}
		else if(hp > 800f && hp <= 900f)
		{
			GUI.DrawTexture (basic, health9);
		}

		if(master_script.selected == 0)
		{
			GUI.DrawTexture (basic, bat_profile);
			hp = master_script.wombat_hp;
		}
		if(master_script.selected == 1)
		{
			GUI.DrawTexture (basic, fe_profile);
			hp = master_script.feman_hp;
		}
		if(master_script.selected == 2)
		{
			GUI.DrawTexture (basic, R_profile);
			hp = master_script.R1_hp;
		}
		if(master_script.selected == 3)
		{
			GUI.DrawTexture (basic, R_profile);
			hp = master_script.R2_hp;
		}
		if(master_script.selected == 4)
		{
			GUI.DrawTexture (basic, R_profile);
			hp = master_script.R3_hp;
		}

		GUI.DrawTexture (basic, hot_keys);
	}

	void Update()
	{
		if(Input.GetKeyDown("1"))
		{
			if(master_script.selected == 0)
			{
				master_script.wombat_attacking = false;
			}
			if(master_script.selected == 1)
			{
				master_script.feman_attacking = false;
			}
			if(master_script.selected == 2)
			{
				master_script.R1_attacking = false;
			}
			if(master_script.selected == 3)
			{
				master_script.R2_attacking = false;
			}
			if(master_script.selected == 4)
			{
				master_script.R3_attacking = false;
			}
		}
	}
}