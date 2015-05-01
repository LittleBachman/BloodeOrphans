using UnityEngine;
using System.Collections;

public class master_script : MonoBehaviour 
{
	public bool talking = false;
	public int selected = 0;

	public bool wombat_attacking = false;
	public bool feman_attacking = false;
	public bool R1_attacking = false;
	public bool R2_attacking = false;
	public bool R3_attacking = false;
	
	public float wombat_hp = 900f;
	public float feman_hp = 900f;
	public float R1_hp = 900f;
	public float R2_hp = 900f;
	public float R3_hp = 900f;
	
	public bool wombat_dead = false;
	public bool feman_dead = false;
	public bool R1_dead = false;
	public bool R2_dead = false;
	public bool R3_dead = false;

	//downstairs
	public bool gate = true;
	public bool door = true;
	public bool jarvis1 = true;

	public int enemies_dead = 0;

	public bool keep_searching_prompt = true;
	public bool go_upstairs_prompt = true;
	public bool can_go_upstairs = false;

	public int snake1_attacking = 0;
	public int snake2_attacking = 0;
	public int snake3_attacking = 0;
	public int snake4_attacking = 0;
	public int snake5_attacking = 0;
	
	public int servant1_attacking = 0;
	public int servant2_attacking = 0;
	public int servant3_attacking = 0;
	public int servant4_attacking = 0;
	public int servant5_attacking = 0;
	public int servant6_attacking = 0;
	public int servant7_attacking = 0;

	//upstairs
	public bool jarvis2 = true;
	public bool jarvis3 = true;
	public bool alfred = true;

	public bool card = false;

	void Start () 
	{
	}

	void Update ()
	{
	}
}
