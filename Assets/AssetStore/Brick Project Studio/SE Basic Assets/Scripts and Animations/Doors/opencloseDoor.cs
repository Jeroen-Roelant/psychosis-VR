using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SojaExiles

{
	public class opencloseDoor : MonoBehaviour
	{

		public Animator openandclose;
		public AudioClip openDoor;
		public AudioClip closeDoor;
		public bool open;
		public bool action;

		void Start()
		{
			open = false;
		}

		void Update()
		{
			{
				if (action)
				{
						if (open == false)
						{

								StartCoroutine(opening());
						}
						else
						{
							if (open == true)
							{
									StartCoroutine(closing());
							}

						}

					action = false;
				}

			}

		}

		IEnumerator opening()
		{
			this.GetComponent<AudioSource>().PlayOneShot(openDoor);
			openandclose.Play("Opening");
			open = true;
			yield return new WaitForSeconds(.5f);
		}

		IEnumerator closing()
		{
			this.GetComponent<AudioSource>().PlayOneShot(closeDoor);
			openandclose.Play("Closing");
			open = false;
			yield return new WaitForSeconds(.5f);
		}


	}
}