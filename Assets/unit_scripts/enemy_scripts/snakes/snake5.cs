﻿using UnityEngine;
using System.Collections;

public class snake5 : MonoBehaviour 
{	
	// References to game controller script
	private master_script master_script;
	public float snake5_hp = 900f;
	
	private enemy_health health_bar ;
	
	void Start () 
	{
		// Find and initialize game controller script so it can be referenced later
		master_script = GameObject.Find("master_index").GetComponent <master_script> ();
		
		health_bar = GameObject.Find("snake5_hp").GetComponent <enemy_health> ();
		
		health_bar.hp = snake5_hp;
	}
	
	void Update () 
	{
		if(snake5_hp > 0f)
		{
			if(master_script.snake5_attacking == 1)
			{
				if(master_script.wombat_attacking == true)
				{
					snake5_hp = snake5_hp - 5.5f;
					master_script.wombat_hp = master_script.wombat_hp - 0.5f;
				}
			}
			if(master_script.snake5_attacking == 2)
			{
				if(master_script.feman_attacking == true);
				{
					snake5_hp = snake5_hp - 5f;
					master_script.feman_hp = master_script.feman_hp - 0.5f;
				}
			}
			if(master_script.snake5_attacking == 3)
			{
				if(master_script.R1_attacking == true)
				{
					snake5_hp = snake5_hp - 4f;
					master_script.R1_hp = master_script.R1_hp - 1.0f;
				}
			}
			if(master_script.snake5_attacking == 4)
			{
				if(master_script.R2_attacking == true)
				{
					snake5_hp = snake5_hp - 4f;
					master_script.R2_hp = master_script.R2_hp - 1.0f;
				}
			}
			if(master_script.snake5_attacking == 5)
			{
				if(master_script.R3_attacking == true)
				{
					snake5_hp = snake5_hp - 4;
					master_script.R3_hp = master_script.R3_hp - 1.0f;
				}
			}
			health_bar.hp = snake5_hp;
		}
		else
		{
			master_script.wombat_attacking = false;
			master_script.feman_attacking = false;
			master_script.R1_attacking = false;
			master_script.R2_attacking = false;
			master_script.R3_attacking = false;

			master_script.enemies_dead++;
			DestroyObject(gameObject);
		}
	}
}