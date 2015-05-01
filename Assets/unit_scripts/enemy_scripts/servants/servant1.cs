using UnityEngine;
using System.Collections;

public class servant1 : MonoBehaviour 
{
	// References to game controller script
	private master_script master_script;
	public float servant1_hp = 900f;
	
	private enemy_health health_bar ;
	
	void Start () 
	{
		// Find and initialize game controller script so it can be referenced later
		master_script = GameObject.Find("master_index").GetComponent <master_script> ();
		
		health_bar = GameObject.Find("servant1_hp").GetComponent <enemy_health> ();
		
		health_bar.hp = servant1_hp;
	}

	void Update () 
	{
		if(servant1_hp > 0f)
		{
			if(master_script.servant1_attacking == 1)
			{
				if(master_script.wombat_attacking == true)
				{
					servant1_hp = servant1_hp - 3.5f;
					master_script.wombat_hp = master_script.wombat_hp - 1.5f;
				}
			}
			if(master_script.servant1_attacking == 2)
			{
				if(master_script.feman_attacking == true)
				{
					servant1_hp = servant1_hp - 3f;
					master_script.feman_hp = master_script.feman_hp - 1f;
				}
			}
			if(master_script.servant1_attacking == 3)
			{
				if(master_script.R1_attacking == true)
				{
					servant1_hp = servant1_hp - 2.3f;
					master_script.R1_hp = master_script.R1_hp - 2f;
				}
			}
			if(master_script.servant1_attacking == 4)
			{
				if(master_script.R2_attacking == true)
				{
					servant1_hp = servant1_hp - 2.3f;
					master_script.R2_hp = master_script.R2_hp - 2f;
				}
			}
			if(master_script.servant1_attacking == 5)
			{
				if(master_script.R3_attacking == true)
				{
					servant1_hp = servant1_hp  - 2.3f;
					master_script.R3_hp = master_script.R3_hp - 2f;
				}
			}
			
			health_bar.hp = servant1_hp;
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