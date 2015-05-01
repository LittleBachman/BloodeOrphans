using UnityEngine;
using System.Collections;

public class servant7 : MonoBehaviour 
{
	// References to game controller script
	private master_script master_script;
	public float servant7_hp = 900f;
	
	private enemy_health health_bar ;
	
	void Start () 
	{
		// Find and initialize game controller script so it can be referenced later
		master_script = GameObject.Find("master_index").GetComponent <master_script> ();
		
		health_bar = GameObject.Find("servant7_hp").GetComponent <enemy_health> ();
		
		health_bar.hp = servant7_hp;
	}
	
	void Update () 
	{
		if(servant7_hp > 0f)
		{
			if(master_script.servant7_attacking == 1)
			{
				if(master_script.wombat_attacking == true)
				{
					servant7_hp = servant7_hp - 4f;
					master_script.wombat_hp = master_script.wombat_hp - 1f;
				}
			}
			if(master_script.servant7_attacking == 2)
			{
				if(master_script.feman_attacking == true)
				{
					servant7_hp = servant7_hp - 3f;
					master_script.feman_hp = master_script.feman_hp - 1f;
				}
			}
			if(master_script.servant7_attacking == 3)
			{
				if(master_script.R1_attacking == true)
				{
					servant7_hp = servant7_hp - 2.5f;
					master_script.R1_hp = master_script.R1_hp - 2f;
				}
			}
			if(master_script.servant7_attacking == 4)
			{
				if(master_script.R2_attacking == true)
				{
					servant7_hp = servant7_hp - 2.5f;
					master_script.R2_hp = master_script.R2_hp - 2f;
				}
			}
			if(master_script.servant7_attacking == 5)
			{
				if(master_script.R3_attacking == true)
				{
					servant7_hp = servant7_hp  - 2.5f;
					master_script.R3_hp = master_script.R3_hp - 2f;
				}
			}
			
			health_bar.hp = servant7_hp;
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