using UnityEngine;
using System.Collections;

public class Rooms : MonoBehaviour {
	int numFamily;
	string name;
	ArrayList family = new ArrayList();
	bool north;
	bool south;
	bool east;
	bool west;

	Rooms (string n){
		this.name = n;
	}
	// Use this for initialization
	void Start () {
	
	}
	 
	public static void addPerson(string name){
		Person p = new Person (name);
		family.Add (p); // is c# dynamic?
	}


	public static bool isNorth(){
		if (this.north) {
						return true;
				} else {
						return false;
				}
	}

	public static bool isEast(){
		if (this.east) {
			return true;
		} else {
			return false;
		}
	}

	public static bool isWest(){
		if (this.west) {
			return true;
		} else {
			return false;
		}
	}

	public static bool isSouth(){
		if (this.south) {
			return true;
		} else {
			return false;
		}
	}

	// Update is called once per frame
	void Update () {
	
	}
}
