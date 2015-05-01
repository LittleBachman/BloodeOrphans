using UnityEngine;
using System.Collections;

public class enemy_health : MonoBehaviour 
{

	public Material hp0;
	public Material hp1;
	public Material hp2;
	public Material hp3;
	public Material hp4;
	public Material hp5;
	public Material hp6;
	public Material hp7;
	public Material hp8;
	public Material hp9;

	public float hp = 900f;

	void Start() 
	{
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(hp < 0f)
		{
			renderer.material = hp0;
		}
		else if(hp > 0f && hp <= 100f)
		{
			renderer.material = hp1;
		}
		else if(hp > 100f && hp <= 200f)
		{
			renderer.material = hp2;
		}
		else if(hp > 200f && hp <= 300f)
		{
			renderer.material = hp3;
		}
		else if(hp > 300f && hp <= 400f)
		{
			renderer.material = hp4;
		}
		else if(hp > 400f && hp <= 500f)
		{
			renderer.material = hp5;
		}
		else if(hp > 500f && hp <= 600f)
		{
			renderer.material = hp6;
		}
		else if(hp > 600f && hp <= 700f)
		{
			renderer.material = hp7;
		}
		else if(hp > 700f && hp <= 800f)
		{
			renderer.material = hp8;
		}
		else if(hp > 800f && hp <= 900f)
		{
			renderer.material = hp9;
		}
	}
}
