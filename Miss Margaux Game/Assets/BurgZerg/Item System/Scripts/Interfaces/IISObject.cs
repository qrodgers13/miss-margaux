using UnityEngine;
using System.Collections;

namespace BurgZergArcade.ItemSystem {

	public interface IISObject {
		//name
		//value - gold value
		//icon or sprite
		//burden
		//quality
		string ISName { get; set; }
		int ISValue { get; set; }
		Sprite ISIcon { get; set; }
		int  ISBurden { get; set; }
		ISQuality ISQuality { get; set; }

		//These go to other item interfaces 
		//equip (true or false)
		//questItem flag
		//durability 
		//takeDamage 
		//prefab

	}

}