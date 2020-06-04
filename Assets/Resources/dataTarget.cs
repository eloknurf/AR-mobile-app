using UnityEngine;
using Vuforia;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

namespace Vuforia
{
public class dataTarget : MonoBehaviour {

		public Transform TextDescription;
		public Transform PanelDescription;

		public AudioSource soundTarget;
		public AudioClip clipTarget;

		// Use this for initialization
		void Start()
		{
			//add Audio Source as new game object component

		}

		// Update is called once per frame
		void Update()
		{
			StateManager sm = TrackerManager.Instance.GetStateManager();
			IEnumerable<TrackableBehaviour> tbs = sm.GetActiveTrackableBehaviours();

			foreach (TrackableBehaviour tb in tbs)
			{
				string name = tb.TrackableName;
				ImageTarget it = tb.Trackable as ImageTarget;
				Vector2 size = it.GetSize();

				Debug.Log("Active image target:" + name + "  -size: " + size.x + ", " + size.y);

				//Evertime the target found it will show “name of target” on the TextTargetName. Button, Description and Panel will visible (active)

				TextDescription.gameObject.SetActive(true);
				PanelDescription.gameObject.SetActive(true);


				//If the target name was “zombie” then add listener to ButtonAction with location of the zombie sound (locate in Resources/sounds folder) and set text on TextDescription a description of the zombie
				if(name == "Cactus1marker"){
					TextDescription.gameObject.SetActive(false);
					PanelDescription.gameObject.SetActive(false);
				}

				if(name == "Cactus2marker"){
					TextDescription.gameObject.SetActive(false);
					PanelDescription.gameObject.SetActive(false);
				}

				if(name == "Cactus3marker"){
					TextDescription.gameObject.SetActive(false);
					PanelDescription.gameObject.SetActive(false);
				}

				if(name == "Cactus4marker"){
					TextDescription.gameObject.SetActive(false);
					PanelDescription.gameObject.SetActive(false);
				}

				if(name == "logo"){
					TextDescription.gameObject.SetActive(false);
					PanelDescription.gameObject.SetActive(false);
				}

				if(name == "qrcactus1"){
					TextDescription.GetComponent<Text>().text = "Golden Barrel Cactus" +
						"\n\nPrize : IDR 20k" +
						"\nInclude : Cactus, Pot, Planting Media" +
						"\nAvailable Stock : >50 pcs" +
						"\n\nDetails :" +
						"\nGolden Barrel Cactus" +
						"Echinocactus grusonii, yang dikenal dengan golden barrel" +
						"cactus, golden ball atau mother in law cushion, adalah spesies kaktus " +
						"yang terkenal dan endemik di Meksiko timur-tengah. Kaktus barrel banyak" +
						"digemari karena mampu bertahan hidup hingga 20 tahun dan bisa tumbuh di daerah tropis " +
						"yang panas seperti Indonesia.";
				}

				if(name == "qrcactus2"){
					TextDescription.GetComponent<Text>().text = "Haworthia Cactus" +
						"\n\nPrize : IDR 30k" +
						"\nInclude : Cactus, Pot, Planting Media" +
						"\nAvailable Stock : >50 pcs" +
						"\n\nDetails :" +
						"\nHaworthia Cactus" +
						"Haworthis Attenuata (Haworthiopsis attenuata) berasal dari" +
						"daerah Eastern Cape, Afrika Selatan. Dikenal sebagai tanaman zebra plant/ tanaman daun batu.";
				}

				if(name == "qrcactus3"){
					TextDescription.GetComponent<Text>().text = "Notocactus magnificus" +
						"\n\nPrize : IDR 40k" +
						"\nInclude : Cactus, Pot, Planting Media" +
						"\n\nDetails :" +
						"\nNotocactus magnificus" +
						"\nNotocactus magnificus merupakan kaktus ‘standar’ yang cukup sering " +
						"ditemui di berbagai nursery. Bentuknya bulat dengan rangka yang tegas serta " +
						"duri-duri halus menghiasi permukaan batangnya.\nMeski terlihat ‘sangar’ dengan " +
						"duri-durinya, sebenarnya Notocactus magnificus merupakan kaktus dengan tipe duri " +
						"halus yang bisa dipegang tanpa menggunakan sarung tangan. Kaktus jenis ini bisa tumbuh " +
						"dalam cluster, bisa juga single plant.";
				}

				if(name == "qrcactus4"){
					TextDescription.GetComponent<Text>().text = "Cactus euphorbia" +
						"\n\nPrize : IDR 50k" +
						"\nInclude : Cactus, Pot, Planting Media"+
						"\n\nDetails :" +
						"\nKaktus euphorbia." +
						"\nEuphorbia berasal dari arab saudi dan yaman. Tanaman jenis ini dapat tumbuh hingga 10m " +
						"dengan batang pendek, mirip beberapa kaktus. Euphorbia tumbuh di daerah berbatu di lereng " +
						"bukit yang curam. Tanaman euphorbia termasuk tanaman yang langka namun tanaman jenis ini " +
						"adalah spesies yang mudah  tumbuh dengan baik dibawah sinar matahari.";
				}
				}
		}

		}

}

