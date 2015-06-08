using UnityEngine;
using System.Collections;

namespace BurgZergArcade.ItemSystem {

	public interface IISStacable  {

		//max stack size
		int MaxStack { get; }
		//stacksize
		int Stack (int amount); // default value of 0

	}

}
