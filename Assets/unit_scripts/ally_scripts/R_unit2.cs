using UnityEngine;
using System.Collections;

public class R_unit2 : MonoBehaviour 
{
	public Vector3 click_location;
	public GameObject prefab;
	NavMeshAgent agent;
	
	public int blood_packet = 3;
	
	// References to game controller script
	private master_script master_script;
	// References to game dialogue
	private dialogue dialogue_script ;
	
	// Use this for initialization
	void Start () 
	{
		// Find and initialize game controller script so it can be referenced later
		master_script = GameObject.Find("master_index").GetComponent <master_script> ();
		
		dialogue_script = GameObject.Find("Main Camera").GetComponent <dialogue> ();

		agent = GetComponent<NavMeshAgent> ();	
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(master_script.talking == false && master_script.R2_attacking == false)
		{
			if(blood_packet == master_script.selected)
			{
				if (Input.GetMouseButtonDown(1))
				{	
					RaycastHit rayHit1;
					
					if (Physics.Raycast (Camera.main.ScreenPointToRay (Input.mousePosition), out rayHit1)) 
					{
						agent.SetDestination(rayHit1.point);
					}
				}
			}
		}
		
		if(master_script.R2_hp <= 0)
		{
			master_script.R2_dead = true;
			master_script.R2_attacking = false;
			DestroyObject(gameObject);
		}
	}
	
	void OnTriggerEnter(Collider other)
	{		
		if(other.tag == "gate")
		{
			if(master_script.gate == true)
			{
				dialogue_script.current_dialogue = 1;
				master_script.talking = true;
			}
		}
		if(other.tag == "door")
		{
			if(master_script.door == true)
			{
				dialogue_script.current_dialogue = 4;
				master_script.talking = true;
			}
		}
		if(other.tag == "jarvis_1")
		{
			if(master_script.jarvis1 == true)
			{
				dialogue_script.current_dialogue = 5;
				master_script.talking = true;
			}
		}
		
		if(other.tag == "jarvis_2")
		{
			if(master_script.jarvis2 == true)
			{
				dialogue_script.current_dialogue = 8;
				dialogue_script.x = 8;
				master_script.talking = true;
			}
			else if(master_script.jarvis3 == true)
			{
				if(master_script.card == true)
				{
					dialogue_script.current_dialogue = 9;
					master_script.talking = true;
				}
			}
		}
		
		if(other.tag == "card")
		{
			master_script.card = true;
		}
		
		if(other.tag == "alfred")
		{
			if(master_script.alfred == true)
			{
				dialogue_script.current_dialogue = 10;
				master_script.talking = true;
			}
		}
		
		if(other.tag == "upstairs")
		{
			if(master_script.enemies_dead >= 12)
			{
				Application.LoadLevel("Upstairs");
			}
			else if(master_script.keep_searching_prompt == true)
			{
				dialogue_script.current_dialogue = 16;
				master_script.talking = true;
			}
		}

		//snakes
		if(other.tag == "snake1")
		{
			master_script.snake1_attacking = 4;
			master_script.R2_attacking = true;
		}
		if(other.tag == "snake2")
		{
			master_script.snake2_attacking = 4;
			master_script.R2_attacking = true;
		}
		if(other.tag == "snake3")
		{
			master_script.snake3_attacking = 4;
			master_script.R2_attacking = true;
		}
		if(other.tag == "snake4")
		{
			master_script.snake4_attacking = 4;
			master_script.R2_attacking = true;
		}
		if(other.tag == "snake5")
		{
			master_script.snake5_attacking = 4;
			master_script.R2_attacking = true;
		}

		//servants
		if(other.tag == "servant1")
		{
			master_script.servant1_attacking = 4;
			master_script.R2_attacking = true;
		}
		if(other.tag == "servant2")
		{
			master_script.servant2_attacking = 4;
			master_script.R2_attacking = true;
		}
		if(other.tag == "servant3")
		{
			master_script.servant3_attacking = 4;
			master_script.R2_attacking = true;
		}
		if(other.tag == "servant4")
		{
			master_script.servant4_attacking = 4;
			master_script.R2_attacking = true;
		}
		if(other.tag == "servant5")
		{
			master_script.servant5_attacking = 4;
			master_script.R2_attacking = true;
		}
		if(other.tag == "servant6")
		{
			master_script.servant6_attacking = 4;
			master_script.R2_attacking = true;
		}		
		if(other.tag == "servant7")
		{
			master_script.servant7_attacking = 4;
			master_script.R2_attacking = true;
		}
	}
}