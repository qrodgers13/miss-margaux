using UnityEngine;
using System.Collections;

namespace BurgZergArcade.ItemSystem {

public interface IISDestructable {

		int Durability { get; }
		int MaxDurability { get; }
		//durability 
		//takeDamage 
		void TakeDamage(int amount); 
		void Repair();
		void Break();

	}

}
