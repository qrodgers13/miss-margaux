using UnityEngine;
using System.Collections;

namespace BurgZergArcade.ItemSystem {

	public interface IISObject {
		//name
		//value - gold value
		//icon or sprite
		//burden
		//quality
		string Name { get; set; }
		int Value { get; set; }
		Sprite Icon { get; set; }
		int  Burden { get; set; }
		ISQuality Quality { get; set; }

		//These go to other item interfaces 
		//equip (true or false)
		//questItem flag

		//prefab

	}

}